using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

public partial class FormTest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Debug.WriteLine("フォームテストなう");
        Debug.WriteLine(Request.Form.Get("textbox"));
        Debug.WriteLine(Request.Form.Get("area"));
        Debug.WriteLine(Request.Form.Get("lang"));//チェックボックスの値全部取れるけど、string なのよね。。。

        //アップロードしたテキストファイルを開く
        //テキストファイル以外はどうするんだと思うがとりあえずお試しで
        System.IO.StreamReader reader = new System.IO.StreamReader(
            Request.Files.Get("file").InputStream
        );
        String text = reader.ReadToEnd();
        Debug.Write(text);
    }
}