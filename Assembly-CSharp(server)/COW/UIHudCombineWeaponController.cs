using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001893 RID: 6291
	[Token(Token = "0x2001893")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F4614", Offset = "0x10F4614")]
	internal class UIHudCombineWeaponController : UIHudButtonBaseController
	{
		// Token: 0x06007CA1 RID: 31905 RVA: 0x000223B0 File Offset: 0x000205B0
		[Token(Token = "0x6007CA1")]
		[Address(RVA = "0x1A90E60", Offset = "0x1A90E60", VA = "0x7BBC290E60")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007CA2 RID: 31906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CA2")]
		[Address(RVA = "0x1A90EB0", Offset = "0x1A90EB0", VA = "0x7BBC290EB0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007CA3 RID: 31907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CA3")]
		[Address(RVA = "0x1A91078", Offset = "0x1A91078", VA = "0x7BBC291078", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007CA4 RID: 31908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CA4")]
		[Address(RVA = "0x1A91198", Offset = "0x1A91198", VA = "0x7BBC291198")]
		private void OnCanCombineChanged(object[] param)
		{
		}

		// Token: 0x06007CA5 RID: 31909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CA5")]
		[Address(RVA = "0x1A912B4", Offset = "0x1A912B4", VA = "0x7BBC2912B4")]
		private void OnCombineStatusChanged(object[] param)
		{
		}

		// Token: 0x06007CA6 RID: 31910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007CA6")]
		[Address(RVA = "0x1A913A0", Offset = "0x1A913A0", VA = "0x7BBC2913A0", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x06007CA7 RID: 31911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CA7")]
		[Address(RVA = "0x1A913E8", Offset = "0x1A913E8", VA = "0x7BBC2913E8")]
		public UIHudCombineWeaponController()
		{
		}

		// Token: 0x04009077 RID: 36983
		[Token(Token = "0x4009077")]
		[FieldOffset(Offset = "0x60")]
		private UIHudCombineWeaponView m_View;
	}
}
