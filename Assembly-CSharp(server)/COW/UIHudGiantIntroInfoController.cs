using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020018D0 RID: 6352
	[Token(Token = "0x20018D0")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F4EBC", Offset = "0x10F4EBC")]
	public class UIHudGiantIntroInfoController : UIBaseController
	{
		// Token: 0x06007E8B RID: 32395 RVA: 0x000229B0 File Offset: 0x00020BB0
		[Token(Token = "0x6007E8B")]
		[Address(RVA = "0x1C17560", Offset = "0x1C17560", VA = "0x7BBC417560")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007E8C RID: 32396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E8C")]
		[Address(RVA = "0x1C175B0", Offset = "0x1C175B0", VA = "0x7BBC4175B0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007E8D RID: 32397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E8D")]
		[Address(RVA = "0x1C176B4", Offset = "0x1C176B4", VA = "0x7BBC4176B4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007E8E RID: 32398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E8E")]
		[Address(RVA = "0x1C1775C", Offset = "0x1C1775C", VA = "0x7BBC41775C")]
		public UIHudGiantIntroInfoController()
		{
		}

		// Token: 0x06007E8F RID: 32399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E8F")]
		[Address(RVA = "0x1C17764", Offset = "0x1C17764", VA = "0x7BBC417764")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1142D24", Offset = "0x1142D24")]
		private void <OnUIInit>b__3_0()
		{
		}

		// Token: 0x040091CC RID: 37324
		[Token(Token = "0x40091CC")]
		[FieldOffset(Offset = "0x58")]
		private UIHudGiantIntroInfoView m_View;

		// Token: 0x040091CD RID: 37325
		[Token(Token = "0x40091CD")]
		[FieldOffset(Offset = "0x60")]
		private uint m_DelayCallId;
	}
}
