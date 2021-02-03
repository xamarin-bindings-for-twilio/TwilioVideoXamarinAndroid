
using System;
using Android.Runtime;

namespace TwilioVideo
{
    public partial class ScreenCapturer
    {
        static Delegate cb_changeCaptureFormat_III;
#pragma warning disable 0169
        static Delegate GetChangeCaptureFormat_IIIHandler()
        {
            if (cb_changeCaptureFormat_III == null)
                cb_changeCaptureFormat_III =
                    JNINativeWrapper.CreateDelegate((_JniMarshal_PPIII_V) n_ChangeCaptureFormat_III);
            return cb_changeCaptureFormat_III;
        }

        static void n_ChangeCaptureFormat_III(IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
        {
            var __this =
                global::Java.Lang.Object.GetObject<global::TwilioVideo.IVideoCapturer>(jnienv, native__this,
                    JniHandleOwnership.DoNotTransfer);
            __this.ChangeCaptureFormat(p0, p1, p2);
        }
#pragma warning restore 0169

        IntPtr id_changeCaptureFormat_III;

        public unsafe void ChangeCaptureFormat(int p0, int p1, int p2)
        {
            if (id_changeCaptureFormat_III == IntPtr.Zero)
                id_changeCaptureFormat_III = JNIEnv.GetMethodID(class_ref, "changeCaptureFormat", "(III)V");
            JValue* __args = stackalloc JValue[3];
            __args[0] = new JValue(p0);
            __args[1] = new JValue(p1);
            __args[2] = new JValue(p2);
            JNIEnv.CallVoidMethod(((global::Java.Lang.Object) this).Handle, id_changeCaptureFormat_III, __args);
        }
    }
}
