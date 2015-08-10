using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.IO;

public partial class FormTest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Debug.WriteLine("フォームテストなう");
        Debug.WriteLine(Request.Form.Get("textbox"));
        Debug.WriteLine(Request.Form.Get("area"));
        var textbox = Request.Form["textbox"];
        var area = Request.Form["area"];
        var lang = Request.Form["lang"];
        Debug.WriteLine(Request.Form.Get("lang"));//チェックボックスの値全部取れるけど、string なのよね。。。

        //アップロードしたテキストファイルを開く
        //テキストファイル以外はどうするんだと思うがとりあえずお試しで
        //HttpPostedFile file = Request.Files.Get("file");
        var file = Request.Files["file"];//Reques.Form 同様これでもいける
        if (file is HttpPostedFile)
        {
            file.SaveAs(Page.MapPath("./sampleimg.jpg"));
            Debug.WriteLine("ファイルを保存しました");
        }


    }
}