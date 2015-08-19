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
        var hoge = Request.Form["hoge"];
        Debug.WriteLine(Request.Form.Get("lang"));//チェックボックスの値全部取れるけど、string なのよね。。。
        HttpPostedFile file = Request.Files["file"];
        try
        {
            Debug.WriteLine("trying");
            //String fullpath = "C:\\Users\\SDP5008\\Desktop\\個人用\\csharp.txt";
            StreamReader reader = new StreamReader(Request.InputStream);
            String result = reader.ReadToEnd();
            Debug.WriteLine(result);
            Debug.WriteLine("success");
            Debug.WriteLine("--breakpoint--");
        }
        catch(NullReferenceException exception)
        {
            var error = exception.Message;
        }

        //GET 用
        var g_text = Request.QueryString["textbox"];
        var g_texts = Request.QueryString["hoge"];
        var g_area = Request.QueryString["area"];
        var g_lang = Request.QueryString["lang"];
        Debug.WriteLine("ここまで");

        //アップロードしたテキストファイルを開く
        //テキストファイル以外はどうするんだと思うがとりあえずお試しで
        //HttpPostedFile file = Request.Files.Get("file");
        //var file = Request.Files["file"];//Reques.Form 同様これでもいける
        //file.SaveAs(Page.MapPath("./sampleimg.jpg"));
        //Debug.WriteLine("ファイルを保存しました");


    }
}