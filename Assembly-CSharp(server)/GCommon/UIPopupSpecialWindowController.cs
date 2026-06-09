using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02001039 RID: 4153
	[Token(Token = "0x2001039")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EA8C0", Offset = "0x10EA8C0")]
	public class UIPopupSpecialWindowController : UIPopupWindowController
	{
		// Token: 0x06003F1E RID: 16158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F1E")]
		[Address(RVA = "0x2032D10", Offset = "0x2032D10", VA = "0x7BBC832D10", Slot = "32")]
		protected override string AnimationConfogPath()
		{
			return null;
		}

		// Token: 0x06003F1F RID: 16159 RVA: 0x00013920 File Offset: 0x00011B20
		[Token(Token = "0x6003F1F")]
		[Address(RVA = "0x2032D58", Offset = "0x2032D58", VA = "0x7BBC832D58", Slot = "31")]
		public override int MinGroupDepth()
		{
			return 0;
		}

		// Token: 0x06003F20 RID: 16160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F20")]
		[Address(RVA = "0x2032D60", Offset = "0x2032D60", VA = "0x7BBC832D60", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06003F21 RID: 16161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F21")]
		[Address(RVA = "0x2032D64", Offset = "0x2032D64", VA = "0x7BBC832D64", Slot = "40")]
		public virtual void OnBackButtonClick()
		{
		}

		// Token: 0x06003F22 RID: 16162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F22")]
		[Address(RVA = "0x2032D68", Offset = "0x2032D68", VA = "0x7BBC832D68", Slot = "41")]
		public virtual void OnEnterButtonClick()
		{
		}

		// Token: 0x06003F23 RID: 16163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F23")]
		[Address(RVA = "0x2032D6C", Offset = "0x2032D6C", VA = "0x7BBC832D6C")]
		public UIPopupSpecialWindowController()
		{
		}
	}
}
