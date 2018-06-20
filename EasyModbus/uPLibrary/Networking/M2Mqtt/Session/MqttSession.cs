﻿// Decompiled with JetBrains decompiler
// Type: uPLibrary.Networking.M2Mqtt.Session.MqttSession
// Assembly: EasyModbus, Version=5.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EBD23A4B-2CA7-473C-89B3-8C8FE0533ECB
// Assembly location: D:\hvu\EasyModbusTCP .NET Package V5.0\EasyModbusTCP .NET Package V5.0\EasyModbusLibrary for .NET (DLL)\EasyModbusLibrary for .NET (DLL)\EasyModbus.dll

using System.Collections;

namespace uPLibrary.Networking.M2Mqtt.Session
{
  public abstract class MqttSession
  {
    public string ClientId { get; set; }

    public Hashtable InflightMessages { get; set; }

    public MqttSession()
      : this((string) null)
    {
    }

    public MqttSession(string clientId)
    {
      this.ClientId = clientId;
      this.InflightMessages = new Hashtable();
    }

    public virtual void Clear()
    {
      this.ClientId = (string) null;
      this.InflightMessages.Clear();
    }
  }
}
