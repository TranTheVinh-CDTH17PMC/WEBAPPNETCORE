﻿function number_format(number, decimals, dec_point, thousands_sep) {
    // *     example: number_format(1234.56, 2, ',', ' ');
    // *     return: '1 234,56'
    number = (number + '').replace(',', '').replace(' ', '');
    var n = !isFinite(+number) ? 0 : +number,
      prec = !isFinite(+decimals) ? 0 : Math.abs(decimals),
      sep = (typeof thousands_sep === 'undefined') ? '.' : thousands_sep,
      dec = (typeof dec_point === 'undefined') ? '.' : dec_point,
      s = '',
      toFixedFix = function (n, prec) {
          var k = Math.pow(10, prec);
          return '' + Math.round(n * k) / k;
      };
    // Fix for IE parseFloat(0.55).toFixed(0) = 0;
    s = (prec ? toFixedFix(n, prec) : '' + Math.round(n)).split('.');
    if (s[0].length > 3) {
        s[0] = s[0].replace(/\B(?=(?:\d{3})+(?!\d))/g, sep);
    }
    if ((s[1] || '').length < prec) {
        s[1] = s[1] || '';
        s[1] += new Array(prec - s[1].length + 1).join('0');
    }
    return s.join(dec);
}
var counter = 0;
$(document).ready(function () {
    GetProducts(0);
    notificationFromHub = $.connection.myHub;
    let scanner = new Instascan.Scanner(
    {
        video: document.getElementById('preview')
    }
                                    );
    scanner.addListener('scan', function (content) {
        var audioElement = document.createElement('audio');
        audioElement.setAttribute('src', '/Assets/jsQR/barcode.wav');
        audioElement.play();
        GetNameCustomer(content);
        $('#create-cust').modal('toggle');
    });
    Instascan.Camera.getCameras().then(cameras => {
        if (cameras.length > 0) {
            scanner.start(cameras[0]);
        } else {
            console.error("Não existe câmera no dispositivo!");
        }
    });
    function End() {
        scanner.stop();
    }
    $('#listOrderDetail').on('change', '.detail_item_qty', function () {
        var $this = $(this);
        var value = $this.val();
        var id = $this.closest('tr').data('id');
        TotalMoney(id);
        calcTotalAmount();
        Excesscash();
        $.ajax({
            url: "/POS/Checksoluong/",
            dataType: "json",
            type: "GET",
            contentType: 'application/json; charset=utf-8',
            data: { Id: id, soluong: value },
            success: function (data) {
                var checknumber = number_format(data);
                var value = $("#Dongia_" + id + "").text(checknumber);
                var x = $("#Price_" + id + "").val(data);
                TotalMoney(id);
                calcTotalAmount();
                Excesscash();
            },
            error: function (err) {
                alert(err);
            }
        });
    });
    $('#listOrderDetail').on('change', '.detail_item_total', function () {
        var $this = $(this);
        var id = $this.closest('tr').data('id');
        TotalMoney(id);
        calcTotalAmount();
    });
    $('#listOrderDetail').on('change', '.detail_item_price', function () {
        var $this = $(this);
        var id = $this.closest('tr').data('id');
        TotalMoney(id);
        calcTotalAmount();
    });
    $("table.order-list").on("click", ".ibtnDel", function (event) {
        $(this).closest("tr").remove();
        $('.detailList tr').each(function (index, tr) {
            $(this).find("span.sn").html(index+1);
            $(tr).find('.detail_item_qty').attr('name', 'ListPOSDetails['+index+'].SoLuong'); 
            $(tr).find('.detail_item_price').attr('name', 'ListPOSDetails['+index+'].DonGia');
            $(tr).find('.detail_item_id').attr('name', 'ListPOSDetails['+index+'].IdThanhPham');
                        
        });
        var count = myTable.querySelectorAll("tr").length;
        if(count == 1)
        {

            $('#Custommer').val("");
            $('#tongtam').val("");
            $('#tiendoidiem').val("");
            $('#totalafterdiscount').val("");  
            $('.Excesscash').text("0");
        }
        else
        {
            calcTotalAmount();
        }   
    });
    $("#dvPassport").hide();
    $("#AddPassport").show();
    $("#Custommer").change(function(){
        Excesscash();
    });
    $("#diemtoida").change(function () {
        debugger
        if ($("#dlcustomer").val() != null && $("#dlcustomer").val() != "") {
            var max = parseInt($(this).attr('max'));
            var min = parseInt($(this).attr('min'));
            if (parseInt($(this).val()) > max) {
                $("#diemtoida").val(max);
            }
            else if (parseInt($(this).val()) < min) {
                $("#diemtoida").val(min);
            }
            Tinhdiemgiamgia();
            calcTotalAmount();
        }
        else {
            $("#khuyenmai").val("0");
        }
        
    });
    $("#khuyenmai").change(function () {
        calcTotalAmount();
    });
    $('#txtName').autocomplete({

        minLength: 1,
        source: function (request, response) {
            $.ajax({
                url: "/POS/Search/",
                dataType: "json",
                type: "GET",
                contentType: 'application/json; charset=utf-8',
                data: { name: request.term },
                success: function (data) {
                    response(data);
                },
                error: function (err) {
                    alert(err);
                }
            });
        },
        focus: updateTextBox,
        select: function (e, ui) {
            SelectProducts(ui.item.Id);
        },
    })

        .autocomplete('instance')._renderItem = function (ul, item) {
            return $('<li class="ui-autocomplete-row"></li>')
                .append('<img src="/Areas/CMS_Sale/Image/ThanhPham/'+item.HinhAnh+'" width="70" />&nbsp;&nbsp;&nbsp;Tên SP : '+item.Ten+' - Đơn giá : '+number_format(item.DonGia)+'')
                .appendTo(ul);
            function updateTextBox(event, ui) {
                $(this).val(ui.item.Id);
                return false;
            }
        };
    $('#dlcustomer').autocomplete({
        minLength: 1,
        source: function (request, response) {
            $.ajax({
                url: "/POS/SearchCustomer/",
                dataType: "json",
                type: "GET",
                contentType: 'application/json; charset=utf-8',
                data: { name: request.term },
                success: function (data) {
                    response(data);
                },
                error: function (err) {
                    alert(err);
                }
            });
        },
        focus: updateTextBox,
        select: function (e, ui) {
            GetNameCustomer(ui.item.Id);
        },
        change: function (e, ui) {
            GetNameCustomer(ui.item.Id);
        }
    })
   .autocomplete('instance')._renderItem = function (ul, item) {
       return $('<li class="ui-autocomplete-row"></li>')
           .append('Tên KH : ' + item.TenKH + ' - SDT : ' + item.SDT + '')
           .appendTo(ul);
   };

    function updateTextBox(event, ui) {
        $('#IdKhachHang').val(ui.item.Id);
        $('#dlcustomer').val(ui.item.TenKH);
        return false;
    }    
});
function Tinhdiemgiamgia()
{
    var checkhuyenmai = $("#checkkhuyenmai").val();
    if (checkhuyenmai != "true")
    {
        var diemhientai = $("#diemtoida").val();
        var tiendoi = $("#tiendoi").val();
        var diemdoi = $("#diemdoi").val();
        var tonggiam = (diemhientai * tiendoi) / diemdoi;
        $("#khuyenmai").val(tonggiam);
    }
}
function GetNameCustomer(id)
{
    var checkhuyenmai = $("#checkkhuyenmai").val();
    $.ajax({
        url: "/POS/GetNameCustomer/",
        dataType: "json",
        type: "GET",
        contentType: 'application/json; charset=utf-8',
        data: { Id: id },
        success: function (data) {
            $.each(data, function (key, item) {
                $('#IdKhachHang').val(item.Id);
                $('#dlcustomer').val(item.TenKH);
                if (checkhuyenmai != "true")
                {
                    $('#diemtoida').val(item.SoDiemToiDa);
                    $('#tiendoi').val(item.SoTien);
                    $('#diemdoi').val(item.SoDiem);
                    $('#diemhienco').val(item.SoDiemToiDa);
                    $('#tienhang').val(item.TienHang);
                    $('#diemhang').val(item.DiemHang);
                    $("#diemtoida").attr({
                        "max": item.SoDiemToiDa,        // substitute your own
                        "min": 0          // values (or variables) here
                    });
                    $('#chkPassport').prop('checked', true);
                    $("#dvPassport").show();
                    $("#AddPassport").hide();
                    Tinhdiemgiamgia();
                    calcTotalAmount();
                }
                
            });
        },
        error: function (xhr) {
            console.log(xhr);
        }
    });
}
function SelectProducts(id)
{
                
    $.ajax({
        url: "/POS/ListProductsById/",
        dataType: "json",
        type: "GET",
        contentType: 'application/json; charset=utf-8',
        data: { Id: id },
        success: function (data) {
            var count = myTable.querySelectorAll("tr").length;
            if (count == null)
            {
                count = 0;
            }
            var getid = $("#" + id + "").val();
            if (getid == null)
            {
                var html = "";
                $.each(data, function (key, item) {
                    html += '<tr data-id="' + item.Id + '"><td id="'+item.Id+'" style="text-align:center"><span class="sn">'+count+'</span></td>';
                    html += '<td style="display:none;"><input class="detail_item_id form-control input-sm" name="ListPOSDetails[' + (count - 1) + '].IdThanhPham"  value="' + item.Id + '"></td>';
                    html += '<td><p type="text">' + item.Ten + '</p></td>';
                    html += '<td><input id="Count_' + item.Id + '" class="detail_item_qty form-control input-sm" type="number" min="1" name="ListPOSDetails[' + (count - 1) + '].SoLuong" value="1"></td>';
                    html += '<td><p id="Dongia_' + item.Id + '" class="detail_item_price" type="text">' + number_format(item.DonGia) + '</p></td>';
                    html += '<td style="display:none;"><input id="Price_' + item.Id + '" class="detail_item_price form-control input-sm" type="text" name="ListPOSDetails[' + (count - 1) + '].DonGia" value="' + item.DonGia + '"></td>';
                    html += '<td><p id="Total_' + item.Id + '" class="detail_item_total"></p></td>';
                    html += '<td style="text-align:center"><i class="ibtnDel fa fa-close" style="font-size:30px;color:red;"></i></td></tr>';
                    $("table.order-list").append(html);
                    TotalMoney(item.Id);
                    calcTotalAmount();
                    counter++;
                                
                });
            }
            else
            {
                var num1 = $("#Count_" + id + "").val();
                var answer = parseInt(num1) + 1;
                $("#Count_" + id + "").val(answer);
                
                $.ajax({
                    url: "/POS/Checksoluong/",
                    dataType: "json",
                    type: "GET",
                    contentType: 'application/json; charset=utf-8',
                    data: { Id: id, soluong: answer },
                    success: function (data) {
                        var x = data;
                        var checknumber = number_format(data);
                        var value = $("#Dongia_" + id + "").text(checknumber);
                        $("#Price_" + id + "").val(x);
                        TotalMoney(id);
                        calcTotalAmount();
                    },
                    error: function (err) {
                        alert(err);
                    }
                });
                
            }

        },
        error: function (xhr) {
            console.log(xhr);
        }
    });
}
function GetProducts(id)
{
    $(".col-md-3").remove();
    $.ajax({
        url: "/POS/ListProducts/",
        dataType: "json",
        type: "GET",
        contentType: 'application/json; charset=utf-8',
        data: { Id: id },
        success: function (data) {
            console.log(data);
            var html = "";
            $.each(data, function (key, item) {
                html += '<div class="col-md-3" style="padding:10px">';
                html += '<div class="content">';
                html += '<a onclick="SelectProducts(' + item.Id + ');">';
                if (item.Khuyenmai != "")
                {
                    html += '<span class="notify-badge">'+item.Khuyenmai+'</span><img src="/Areas/CMS_Sale/Image/ThanhPham/' + item.HinhAnh + '" alt="Mountains" style="width:100%">';
                }
                if (item.Khuyenmai == "")
                {
                    html += '<img src="/Areas/CMS_Sale/Image/ThanhPham/' + item.HinhAnh + '" alt="Mountains" style="width:100%">';
                }
                html += '</a><h4>' + item.Ten + '</h4>';
                html += '<p>' + number_format(item.DonGia) + '</p>';
                html += '</div></div>';
            });
            $("#rowproduct").append(html);
        },
        error: function (xhr) {
            console.log(xhr);
        }
    });
}
function TotalMoney(id)
{
    var num1 = $("#Count_"+id+"").val();
    var num2 = $("table.order-list #Price_" + id + "").val();
    var answer = parseInt(num1) * parseInt(num2);
    $("table.order-list #Total_" +id+ "").text(number_format(answer));
    $("table.order-list #Total_" +id+ "").val(answer);
    Excesscash();
}
function calcTotalAmount() {
    var total = 0;
    var total1 = 0;
    var tiendoidiem = 0;
    var tiendoi = $("#tienhang").val();
    var diemdoi = $("#diemhang").val();
    var selector = '.detailList tr';
    $('table > tbody  > tr').each(function (index, elem) {
        if ($(elem).find('.detail_item_total').text() != '') {
            total = total + parseFloat($(elem).find('.detail_item_total').val());
            $("#tongtam").val(total);
            total1 = total - $("#TongKM").val();
            if (total1 < 0)
            {
                total1 = 0;
            }
            
           
            $("#totalafterdiscount").val(total1);
            $('input[name="TongTien"]').val(total1);        
        }
    });
    if (tiendoi == 0)
    {
        tiendoidiem = 0;
    }
    else
    {
        tiendoidiem = (total1 / tiendoi)*diemdoi;
    }
    $("#tiendoidiem").val(Math.floor(tiendoidiem));
    Excesscash();
}
function Excesscash()
{
    var cus = $("#Custommer").val();
    var total = $("#totalafterdiscount").val();
    var sum = cus.replace(",","");
    var sum1 = total.replace(",","");
    cus = sum.replace(",","");
    total = sum1.replace(",","");
    var answer = parseFloat(cus) - parseFloat(total);
    $(".Excesscash").text(numeral(answer).format('0,0'));
    $(".Excesscash").val(numeral(answer).format('0,0'));
    
}

//Javascript tìm kiếm sản phẩm
function myFunction() {
    document.getElementById("myDropdown").classList.toggle("show");
}

function filterFunction() {
    var input, filter, ul, li, tr, i;
    input = document.getElementById("myInput");
    filter = input.value.toUpperCase();
    div = document.getElementById("myDropdown");
    tr = div.getElementsByTagName("tr");
    for (i = 0; i < tr.length; i++) {
        txtValue = tr[i].textContent || tr[i].innerText;
        if (txtValue.toUpperCase().indexOf(filter) > -1) {
            tr[i].style.display = "";
        } else  {
            tr[i].style.display = "none";
        }
    }
}

document.addEventListener('keyup', hotkey, false);