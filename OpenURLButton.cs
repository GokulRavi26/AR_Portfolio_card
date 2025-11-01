using UnityEngine;

public class OpenURLButton : MonoBehaviour
{
    // Opens GitHub profile
    public void OpenGitHub()
    {
        Application.OpenURL("https://github.com/GokulRavi26/");
    }

    // Opens Google Maps or Search result for your location
    public void OpenLocation()
    {
        Application.OpenURL("https://www.google.com/search?q=sankari+tamilnadu&oq=sankari+tamilnadu&gs_lcrp=EgZjaHJvbWUqBggAEEUYOzIGCAAQRRg7MgkIARAuGA0YgAQyCAgCEAAYDRgeMggIAxAAGA0YHjIKCAQQABgFGA0YHtIBCDUwODBqMGo3qAIAsAIA&sourceid=chrome&ie=UTF-8#vhid=0x0:0x9c1613a34398bb7e&vssid=lclsmap&eim=CAEQEBoSMTEuNDcyNzIxNDg4ODg3NTk3IhE3Ny44NjcxNTM5NTU0MTE3OCoUMTEyNDcxOTg3MTEzMzkwNzIzODI");
    }

    // Opens the Projects section of your Portfolio
    public void OpenProjects()
    {
        Application.OpenURL("https://gokulravi26.github.io/Portfolio/#projects");
    }

    // Opens LinkedIn profile
    public void OpenLinkedIn()
    {
        Application.OpenURL("https://www.linkedin.com/in/gokul2609/");
    }

    // Opens main Portfolio page
    public void OpenPortfolio()
    {
        Application.OpenURL("https://gokulravi26.github.io/Portfolio/");
    }

    // Opens resume from Google Drive
    public void OpenResume()
    {
        Application.OpenURL("https://drive.google.com/file/d/1c3u9aafZ1fo9TBuaEP5WpFR5sJu8TkMr/view?usp=sharing");
    }

    // Opens mail client to send email
    public void SendEmail()
    {
        Application.OpenURL("mailto:gokulravi2609@gmail.com");
    }

    // Opens dialer with phone number
    public void DialPhone()
    {
        Application.OpenURL("tel:+916382698277");
    }
}
