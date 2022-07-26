

public class ResponseDto : NewBaseType
{


    public static bool isValid(string data)
    {
        bool flag = true;

        for (int i = 0; i < data.Length; i++)
        {
            if (!char.IsLetter(data[i]))
            {
                flag = false;
                break;
            }
        }

        return flag;
    }


}
public class NewBaseType
{
    public List<ResponseDto> StateList()
    {
        var responseString = ApiCallService.GetApi("https://funtranslations.com/api/#leetspeak");
        var rootobject = new JavaScriptSerializer().Deserialize<List<ResponseDto>>(responseString);
        return (List<ResponseDto>)rootobject;
    }
}