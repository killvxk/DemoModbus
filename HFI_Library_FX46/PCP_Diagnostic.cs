﻿// Decompiled with JetBrains decompiler
// Type: PhoenixContact.HFI.Inline.PCP_Diagnostic
// Assembly: HFI_Library_FX46, Version=3.2.6053.23249, Culture=neutral, PublicKeyToken=bbf13850d99d956d
// MVID: 42FFD0DD-74E7-4B38-A116-483C52C5F352
// Assembly location: D:\Program Files (x86)\Phoenix Contact\HFI 3.2\HFI_Tools\Libraries\HFI_Library_FX46.dll

namespace PhoenixContact.HFI.Inline
{
  public enum PCP_Diagnostic
  {
    Inactive = 0,
    NoError = 33536, // 0x00008300
    ConfirmationTimeout = 49156, // 0x0000C004
    UnexpectedService = 49157, // 0x0000C005
    NegativeInitiateConfirmation = 49409, // 0x0000C101
    NegativeReadConfirmation = 49922, // 0x0000C302
    NegativeWriteConfirmation = 49923, // 0x0000C303
    UnkonwnService = 49924, // 0x0000C304
    ReceiveDataTooLong = 49925, // 0x0000C305
    MessageClientDiagnostic = 51712, // 0x0000CA00
  }
}
