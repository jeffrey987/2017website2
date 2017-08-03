/*分类选择层开始----------暂时没有用*/
var openCategorySelectLayerBut = null;
var categorySelectLayerHtml = "<div class='selectBoxProgressBar'><p><img src='/admin/skin/default/progressbar.gif'/></p></div>";

function categoryTree(obj, layer) {
    var state = $(obj).attr("class");
    if (state == "open") {
        $(obj).parent().parent().nextAll().each(function (index) {
            var flag = parseInt($(this).attr("layer")) - layer;
            if (flag == 1) {
                $(this).show();
            }
            else if (flag == 0) {
                return false;
            }
        })
        $(obj).removeClass("open").addClass("close");
    }
    else if (state == "close") {
        $(obj).parent().parent().nextAll().each(function (index) {
            if (parseInt($(this).attr("layer")) > layer) {
                $(this).hide();
                $(this).find("th span").each(function (i) {
                    if (typeof ($(this).attr("class")) != "undefined" && $(this).attr("class") !== "") {
                        $(this).removeClass("close").addClass("open");
                    }
                })
            }
            else {
                return false;
            }
        })
        $(obj).removeClass("close").addClass("open");
    }
}

function setSelectedCategory(selectedCateId, selectedCateName) {
    $(openCategorySelectLayerBut).parent().find(".CateId").val(selectedCateId);
    $(openCategorySelectLayerBut).val(selectedCateName).parent().find(".CategoryName").val(selectedCateName);
    $.jBox.close('categorySelectLayer');
}

function ajaxCategorySelectList() {
    $.jBox.setContent(categorySelectLayerHtml);
    $.get("/tools/admin_ajax.ashx?action=get_school&t=" + new Date(), function (data) {
        $.jBox.setContent(data);
    })
}

function openCategorySelectLayer(openLayerBut) {
    $.jBox('html:categorySelectLayer', {
        id: 'categorySelectLayer',
        width: 550,
        buttons: { '关闭': true },
        title: "选择类别"
    });
    openCategorySelectLayerBut = openLayerBut;
    ajaxCategorySelectList();
}


/*分类选择层结束*/

/*学科选择层开始*/
var openSubjectSelectLayerBut = null;
var subjectSelectLayerHtml = "<div class='selectBoxProgressBar'><p><img src='/admin/skin/default/progressbar.gif'/></p></div>";

function subjectTree(obj, layer) {
    var state = $(obj).attr("class");
    if (state == "open") {
        $(obj).parent().parent().nextAll().each(function (index) {
            var flag = parseInt($(this).attr("layer")) - layer;
            if (flag == 1) {
                $(this).show();
            }
            else if (flag == 0) {
                return false;
            }
        })
        $(obj).removeClass("open").addClass("close");
    }
    else if (state == "close") {
        $(obj).parent().parent().nextAll().each(function (index) {
            if (parseInt($(this).attr("layer")) > layer) {
                $(this).hide();
                $(this).find("th span").each(function (i) {
                    if (typeof ($(this).attr("class")) != "undefined" && $(this).attr("class") !== "") {
                        $(this).removeClass("close").addClass("open");
                    }
                })
            }
            else {
                return false;
            }
        })
        $(obj).removeClass("close").addClass("open");
    }
}

function setSelectedSubject(selectedSubjectId, selectedSubjectName) {
    $(openSubjectSelectLayerBut).parent().find(".SubjectId").val(selectedSubjectId);
    $(openSubjectSelectLayerBut).val(selectedSubjectName).parent().find(".SubjectName").val(selectedSubjectName);
    $.jBox.close('subjectSelectLayer');
}

function ajaxSubjectSelectList() {
    $.jBox.setContent(subjectSelectLayerHtml);
    $.get("/tools/admin_ajax.ashx?action=get_subject&t=" + new Date(), function (data) {
        $.jBox.setContent(data);
    })
}

function openSubjectSelectLayer(openLayerBut) {
    $.jBox('html:subjectSelectLayer', {
        id: 'subjectSelectLayer',
        width: 550,
        buttons: { '关闭': true },
        title: "选择类别"
    });
    openSubjectSelectLayerBut = openLayerBut;
    ajaxSubjectSelectList();
}
/*学科选择层结束*/

