using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020018B8 RID: 6328
	[Token(Token = "0x20018B8")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F4AAC", Offset = "0x10F4AAC")]
	public class UIHudEscortightStartTimeTipController : UIBaseController
	{
		// Token: 0x06007DE6 RID: 32230 RVA: 0x000227D0 File Offset: 0x000209D0
		[Token(Token = "0x6007DE6")]
		[Address(RVA = "0x1C0AC34", Offset = "0x1C0AC34", VA = "0x7BBC40AC34")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007DE7 RID: 32231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DE7")]
		[Address(RVA = "0x1C0AC84", Offset = "0x1C0AC84", VA = "0x7BBC40AC84", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007DE8 RID: 32232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DE8")]
		[Address(RVA = "0x1C0ACE8", Offset = "0x1C0ACE8", VA = "0x7BBC40ACE8")]
		private void Update()
		{
		}

		// Token: 0x06007DE9 RID: 32233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DE9")]
		[Address(RVA = "0x1C0AF9C", Offset = "0x1C0AF9C", VA = "0x7BBC40AF9C")]
		public UIHudEscortightStartTimeTipController()
		{
		}

		// Token: 0x0400914A RID: 37194
		[Token(Token = "0x400914A")]
		[FieldOffset(Offset = "0x58")]
		private UIHudEscortFightStartTimeTipView m_View;

		// Token: 0x0400914B RID: 37195
		[Token(Token = "0x400914B")]
		[FieldOffset(Offset = "0x60")]
		private int lastLeftTimeS;
	}
}
