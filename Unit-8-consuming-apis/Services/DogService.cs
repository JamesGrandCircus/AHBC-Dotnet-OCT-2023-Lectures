namespace Unit_8_consuming_apis.Services
{
    interface IDoThing
    {
        void DoThing();
    }



    // always name your services related to the ACTUAL 
    // api serrvice you will communicating... this is OOP
    public class DogService
    {
        private readonly HttpClient _client;

        // we are injecting the http client we depend on!
        public DogService(HttpClient client)
        {
            _client = client;
        }

        // A TASK of nothing (no angle brackets) is just an ASYNC void method
        // the method does something, but returns NOTHING
        public async Task<string> GetRandomDogImage()
        {
            // the way you read the Task type, is a Task is the 
            // thing that you WANT to get done, and the type inside
            // the angle brackets (*generics) will be the end result
            // of that task. ie. when the task is completed, you will
            // get back an HttpResonseMessage
            //
            // A Task can be for anything, 
            //
            // Task<HttpResponseMessage>
            //
            // the await keyword "unwraps" the TAsk type, giving you
            // what the Task was meaning to GET YOU to begin with.
            //
            //  IF the method you are calling returns a TASK.
            //
            //  1) put await in front of the method name
            //  2) make your return type a TAsk instead, and put 
            //     put your intended return type in the angle brackets
            //  3) add the async modifier to your method.
            //
            //
            var httpResponseMessage = await _client.GetAsync("breeds/image/random");
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                // Content == Body
                // this method will READ the JSON and CONVERT into a C# OBject
                // FOR YOU!!!
                DogImageMessage dogImageMessage = await httpResponseMessage.Content.ReadFromJsonAsync<DogImageMessage>();
                return dogImageMessage.message;
            }
            else
            {
                throw new Exception("no dog! no business... I\"m crashing");
            }

        }

    }

}
