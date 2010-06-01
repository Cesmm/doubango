/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class MessagingSession : SipSession {
  private HandleRef swigCPtr;

  internal MessagingSession(IntPtr cPtr, bool cMemoryOwn) : base(tinyWRAPPINVOKE.MessagingSessionUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(MessagingSession obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~MessagingSession() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          tinyWRAPPINVOKE.delete_MessagingSession(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public MessagingSession(SipStack Stack) : this(tinyWRAPPINVOKE.new_MessagingSession(SipStack.getCPtr(Stack)), true) {
  }

  public bool Send(byte[] payload, uint len) {
    bool ret = tinyWRAPPINVOKE.MessagingSession_Send(swigCPtr, payload, len);
    return ret;
  }

  public bool Accept() {
    bool ret = tinyWRAPPINVOKE.MessagingSession_Accept(swigCPtr);
    return ret;
  }

  public bool Reject() {
    bool ret = tinyWRAPPINVOKE.MessagingSession_Reject(swigCPtr);
    return ret;
  }

}
