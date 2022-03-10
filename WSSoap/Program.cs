// See https://aka.ms/new-console-template for more information

using System.Net;
using System.Xml;

Execute();

static void Execute()
{
    HttpWebRequest request = CreateWebRequest();
    XmlDocument soapEnvelopeXml = new XmlDocument();
    soapEnvelopeXml.LoadXml(@"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/""
        xmlns:servicens=""http://service.jaxws.session4.sdj3.dk.via/"">
                        <soapenv:Header/>
    <soapenv:Body>
        <servicens:wakeUp>
            <name>Emiliano</name>
        </servicens:wakeUp>
    </soapenv:Body>
</soapenv:Envelope>");

    using (Stream stream = request.GetRequestStream())
    {
        soapEnvelopeXml.Save(stream);
    }

    using (WebResponse response = request.GetResponse())
    {
        using (StreamReader rd = new StreamReader(response.GetResponseStream()))
        {
            string soapResult = rd.ReadToEnd();
            Console.WriteLine(soapResult);
        }
    }
}

static HttpWebRequest CreateWebRequest()
{
    HttpWebRequest webRequest = (HttpWebRequest) WebRequest.Create("http://localhost:9090/jaxws-wakeUp-service");
    webRequest.Headers.Add(@"SOAP:Action");
    webRequest.ContentType = "text/xml;charset=\"utf-8\"";
    webRequest.Accept = "text/xml";
    webRequest.Method = "POST";
    return webRequest;
}