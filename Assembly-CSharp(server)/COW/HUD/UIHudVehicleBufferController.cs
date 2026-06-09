using System;
using GCommon;
using Il2CppDummyDll;

namespace COW.HUD
{
	// Token: 0x02002677 RID: 9847
	[Token(Token = "0x2002677")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FE3C8", Offset = "0x10FE3C8")]
	public class UIHudVehicleBufferController : UIBaseController
	{
		// Token: 0x17000DA8 RID: 3496
		// (get) Token: 0x0600CB82 RID: 52098 RVA: 0x00036AE0 File Offset: 0x00034CE0
		[Token(Token = "0x17000DA8")]
		public uint \u007FvnE~s\u0080
		{
			[Token(Token = "0x600CB82")]
			[Address(RVA = "0x1848950", Offset = "0x1848950", VA = "0x7BBC048950")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x0600CB83 RID: 52099 RVA: 0x00036AF8 File Offset: 0x00034CF8
		[Token(Token = "0x600CB83")]
		[Address(RVA = "0x1848958", Offset = "0x1848958", VA = "0x7BBC048958")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600CB84 RID: 52100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB84")]
		[Address(RVA = "0x18489A8", Offset = "0x18489A8", VA = "0x7BBC0489A8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600CB85 RID: 52101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB85")]
		[Address(RVA = "0x1848AD8", Offset = "0x1848AD8", VA = "0x7BBC048AD8")]
		public void ResetUIData(uint fNeYtWu)
		{
		}

		// Token: 0x0600CB86 RID: 52102 RVA: 0x00036B10 File Offset: 0x00034D10
		[Token(Token = "0x600CB86")]
		[Address(RVA = "0x1848D1C", Offset = "0x1848D1C", VA = "0x7BBC048D1C")]
		public float UpdateView()
		{
			return 0f;
		}

		// Token: 0x0600CB87 RID: 52103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB87")]
		[Address(RVA = "0x1848DDC", Offset = "0x1848DDC", VA = "0x7BBC048DDC")]
		public UIHudVehicleBufferController()
		{
		}

		// Token: 0x0400FFC9 RID: 65481
		[Token(Token = "0x400FFC9")]
		[FieldOffset(Offset = "0x58")]
		private UIHudVehicleBufferView p|r\u007Fnuf;

		// Token: 0x0400FFCA RID: 65482
		[Token(Token = "0x400FFCA")]
		[FieldOffset(Offset = "0x60")]
		private float stXFpBC;

		// Token: 0x0400FFCB RID: 65483
		[Token(Token = "0x400FFCB")]
		[FieldOffset(Offset = "0x64")]
		private float JUEdvm\u0080;

		// Token: 0x0400FFCC RID: 65484
		[Token(Token = "0x400FFCC")]
		[FieldOffset(Offset = "0x68")]
		private uint k|N]zEy;
	}
}
