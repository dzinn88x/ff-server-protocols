using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020018DA RID: 6362
	[Token(Token = "0x20018DA")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F500C", Offset = "0x10F500C")]
	internal class UIHudGrenadeSubHintController : UIBaseController
	{
		// Token: 0x06007EDE RID: 32478 RVA: 0x00022AD0 File Offset: 0x00020CD0
		[Token(Token = "0x6007EDE")]
		[Address(RVA = "0x197D674", Offset = "0x197D674", VA = "0x7BBC17D674")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007EDF RID: 32479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EDF")]
		[Address(RVA = "0x197D6C4", Offset = "0x197D6C4", VA = "0x7BBC17D6C4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007EE0 RID: 32480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EE0")]
		[Address(RVA = "0x197B8E8", Offset = "0x197B8E8", VA = "0x7BBC17B8E8")]
		public void SetActive(bool val)
		{
		}

		// Token: 0x06007EE1 RID: 32481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EE1")]
		[Address(RVA = "0x197D000", Offset = "0x197D000", VA = "0x7BBC17D000")]
		public void SetHintType(UIHudGrenadeHintController.HintType hinttype)
		{
		}

		// Token: 0x06007EE2 RID: 32482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EE2")]
		[Address(RVA = "0x197D728", Offset = "0x197D728", VA = "0x7BBC17D728")]
		public UIHudGrenadeSubHintController()
		{
		}

		// Token: 0x0400920A RID: 37386
		[Token(Token = "0x400920A")]
		[FieldOffset(Offset = "0x58")]
		private UIHudGrenadeSubHintView m_View;
	}
}
