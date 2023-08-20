// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class chatgpt : MonoBehaviour
// {
//     private OpenAIApi openai= new OpenAIApi();
//     priveate List<ChatMessage> messages =new List<ChatMessage>();

    
//     public async void askchatgpt(string newText)
//     {
//         ChatMessage newmassages= new ChatMessage();
//         newmassages.Content = newText;
//         newmassages.Role = "user";
//         messages.Add(newmassages);
//         CreateChatCompletionRequest request = new CreateChatCompletionRequest();
//         request.Messages=messages;
//         request.Model = "gpt-3.5-turbo";
//         var response =await openai.CreateChatCompletionRequest(request);

//         if(response.Choices!=null && response.Choices.Count>0)
//         {
//             var chatResponse =response.Choices[0].Messages;
//             messages.Add(chatResponse);

//             Debug.Log(chatResponse.Content);
//         }

//     }
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }
// }
