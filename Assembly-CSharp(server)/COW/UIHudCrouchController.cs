using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020018A0 RID: 6304
	[Token(Token = "0x20018A0")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F47BC", Offset = "0x10F47BC")]
	internal class UIHudCrouchController : UIHudButtonBaseController
	{
		// Token: 0x06007D13 RID: 32019 RVA: 0x00022500 File Offset: 0x00020700
		[Token(Token = "0x6007D13")]
		[Address(RVA = "0x1A9F66C", Offset = "0x1A9F66C", VA = "0x7BBC29F66C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007D14 RID: 32020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D14")]
		[Address(RVA = "0x1A9F6BC", Offset = "0x1A9F6BC", VA = "0x7BBC29F6BC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007D15 RID: 32021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007D15")]
		[Address(RVA = "0x1A9F780", Offset = "0x1A9F780", VA = "0x7BBC29F780", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x06007D16 RID: 32022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D16")]
		[Address(RVA = "0x1A9F7C8", Offset = "0x1A9F7C8", VA = "0x7BBC29F7C8")]
		private void Update()
		{
		}

		// Token: 0x06007D17 RID: 32023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D17")]
		[Address(RVA = "0x1A9F8A8", Offset = "0x1A9F8A8", VA = "0x7BBC29F8A8")]
		private void SetHightlight(bool highlight)
		{
		}

		// Token: 0x06007D18 RID: 32024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D18")]
		[Address(RVA = "0x1A9F9E4", Offset = "0x1A9F9E4", VA = "0x7BBC29F9E4")]
		public UIHudCrouchController()
		{
		}

		// Token: 0x040090C7 RID: 37063
		[Token(Token = "0x40090C7")]
		[FieldOffset(Offset = "0x60")]
		private UIHudCrouchView m_View;

		// Token: 0x040090C8 RID: 37064
		[Token(Token = "0x40090C8")]
		[FieldOffset(Offset = "0x68")]
		private bool m_IsHighlight;
	}
}
