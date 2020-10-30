using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Bolt;

public class NetworkEvent : MonoBehaviour
{
       public void  OnConnectedToMaster()
        {
            CustomEvent.Trigger(this.gameObject, "OnConnectedToMaster");
        }
    public void OnJoinedLobby()
    {
        CustomEvent.Trigger(this.gameObject, "OnJoinedLobby");
    }
    public void OnJoinedRoom()
    {
        CustomEvent.Trigger(this.gameObject, "OnJoinedRoom");

    }

}
