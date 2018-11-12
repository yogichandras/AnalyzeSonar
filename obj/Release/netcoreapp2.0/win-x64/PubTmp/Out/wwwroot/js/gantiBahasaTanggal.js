function cari(x, y) {
    var nilai = "gagal";
    var query = x;
    var data = y;
    if (query == 1) {
        if (data == "Sunday") {
            nilai = "Minggu";
        }
        if (data == "Monday") {
            nilai = "Senin";
        }
        if (data == "Tuesday") {
            nilai = "Selasa";
        }
        if (data == "Wednesday") {
            nilai = "Rabu";
        }
        if (data == "Thursday") {
            nilai = "Kamis";
        }
        if (data == "Friday") {
            nilai = "Jumat";
        }
        if (data == "Saturday") {
            nilai = "Sabtu";
        }

    }
    if (query == 2) {
        if (data == "January" || data == "01") {
            nilai = "Januari";
        }
        if (data == "February" || data == "02") {
            nilai = "Februari";
        }
        if (data == "March" || data == "03") {
            nilai = "Maret";
        }
        if (data == "April" || data == "04") {
            nilai = "April";
        }
        if (data == "May" || data == "05") {
            nilai = "Mei";
        }
        if (data == "June" || data == "06") {
            nilai = "Juni";
        }
        if (data == "July" || data == "07") {
            nilai = "Juli";
        }
        if (data == "August" || data == "08") {
            nilai = "Agustus";
        }
        if (data == "September" || data == "09") {
            nilai = "September";
        }
        if (data == "October" || data == "10") {
            nilai = "Oktober";
        }
        if (data == "November" || data == "11") {
            nilai = "November";
        }
        if (data == "December" || data == "12") {
            nilai = "Desember";
        }
    }
    if (query == 3) {
        if (data == "Sun") {
            nilai = "Min";
        }
        if (data, "ddd" == "Mon") {
            nilai = "Sen";
        }
        if (data == "Tue") {
            nilai = "Sel";
        }
        if (data == "Wed") {
            nilai = "Rab";
        }
        if (data == "Thu") {
            nilai = "Kam";
        }
        if (data == "Fri") {
            nilai = "Jum";
        }
        if (data == "Sat") {
            nilai = "Sab";
        }

    }
    if (query == 4) {
        if (data == "Jan") {
            nilai = "Jan";
        }
        if (data == "Feb") {
            nilai = "Feb";
        }
        if (data == "Mar") {
            nilai = "Mar";
        }
        if (data == "Apr") {
            nilai = "Apr";
        }
        if (data == "May") {
            nilai = "Mei";
        }
        if (data == "Jun") {
            nilai = "Jun";
        }
        if (data == "Jul") {
            nilai = "Jul";
        }
        if (data == "Aug") {
            nilai = "Agu";
        }
        if (data == "Sep") {
            nilai = "Sep";
        }
        if (data == "Oct") {
            nilai = "Okt";
        }
        if (data == "Nov") {
            nilai = "Nov";
        }
        if (data == "Dec") {
            nilai = "Des";
        }
    }
    return nilai;
}