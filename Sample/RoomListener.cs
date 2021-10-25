using System;
using Java.Interop;
using TwilioVideo;

namespace Sample
{
    public class RoomListener : Java.Lang.Object, Room.IListener
    {
        #region Fields

        private static RoomListener _instance;

        #endregion

        #region Properties

        public static RoomListener Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RoomListener();
                }

                return _instance;
            }
        }

        #endregion

        #region Methods

        public void OnConnectFailure(Room p0, TwilioException p1)
        {
            Console.WriteLine("OnConnectFailure");
        }

        public void OnConnected(Room p0)
        {
            Console.WriteLine("OnConnected");
        }

        public void OnDisconnected(Room p0, TwilioException p1)
        {
            Console.WriteLine("OnDisconnected");
        }

        public void OnDominantSpeakerChanged(Room room, RemoteParticipant remoteParticipant)
        {
            Console.WriteLine("OnDominantSpeakerChanged");
        }

        public void OnParticipantConnected(Room p0, RemoteParticipant p1)
        {
            Console.WriteLine("OnParticipantConnected");
        }

        public void OnParticipantDisconnected(Room p0, RemoteParticipant p1)
        {
            Console.WriteLine("OnParticipantDisconnected");
        }

        public void OnReconnected(Room p0)
        {
            Console.WriteLine("OnReconnected");
        }

        public void OnReconnecting(Room p0, TwilioException p1)
        {
            Console.WriteLine("OnReconnecting");
        }

        public void OnRecordingStarted(Room p0)
        {
            Console.WriteLine("OnRecordingStarted");
        }

        public void OnRecordingStopped(Room p0)
        {
            Console.WriteLine("OnRecordingStopped");
        }

        #endregion
    }
}
