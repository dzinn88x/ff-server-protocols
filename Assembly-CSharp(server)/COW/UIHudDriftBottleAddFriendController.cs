using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020018AC RID: 6316
	[Token(Token = "0x20018AC")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F48CC", Offset = "0x10F48CC")]
	public class UIHudDriftBottleAddFriendController : UIBaseController
	{
		// Token: 0x06007D85 RID: 32133 RVA: 0x00022680 File Offset: 0x00020880
		[Token(Token = "0x6007D85")]
		[Address(RVA = "0x1BFF7CC", Offset = "0x1BFF7CC", VA = "0x7BBC3FF7CC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007D86 RID: 32134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D86")]
		[Address(RVA = "0x1BFF81C", Offset = "0x1BFF81C", VA = "0x7BBC3FF81C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007D87 RID: 32135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D87")]
		[Address(RVA = "0x1BFF9B0", Offset = "0x1BFF9B0", VA = "0x7BBC3FF9B0")]
		public void ShowMessage(ulong userID, string userName)
		{
		}

		// Token: 0x06007D88 RID: 32136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D88")]
		[Address(RVA = "0x1BFFCD4", Offset = "0x1BFFCD4", VA = "0x7BBC3FFCD4")]
		private void OnOkBtnClick()
		{
		}

		// Token: 0x06007D89 RID: 32137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D89")]
		[Address(RVA = "0x1BFFE2C", Offset = "0x1BFFE2C", VA = "0x7BBC3FFE2C")]
		private void OnCloseBtnClick()
		{
		}

		// Token: 0x06007D8A RID: 32138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D8A")]
		[Address(RVA = "0x1BFFF24", Offset = "0x1BFFF24", VA = "0x7BBC3FFF24", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06007D8B RID: 32139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D8B")]
		[Address(RVA = "0x1C00038", Offset = "0x1C00038", VA = "0x7BBC400038")]
		public UIHudDriftBottleAddFriendController()
		{
		}

		// Token: 0x0400911E RID: 37150
		[Token(Token = "0x400911E")]
		[FieldOffset(Offset = "0x58")]
		private UIHudDriftBottleAddFriendView m_View;

		// Token: 0x0400911F RID: 37151
		[Token(Token = "0x400911F")]
		[FieldOffset(Offset = "0x60")]
		private UIModelFriends m_Model;

		// Token: 0x04009120 RID: 37152
		[Token(Token = "0x4009120")]
		[FieldOffset(Offset = "0x68")]
		private uint m_CloseDelayCallID;

		// Token: 0x04009121 RID: 37153
		[Token(Token = "0x4009121")]
		[FieldOffset(Offset = "0x6C")]
		private uint m_TimeDelayCallID;

		// Token: 0x04009122 RID: 37154
		[Token(Token = "0x4009122")]
		[FieldOffset(Offset = "0x70")]
		private ulong m_BindUserID;

		// Token: 0x020018AD RID: 6317
		[Token(Token = "0x20018AD")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F4904", Offset = "0x10F4904")]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x06007D8C RID: 32140 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D8C")]
			[Address(RVA = "0x1BFFCCC", Offset = "0x1BFFCCC", VA = "0x7BBC3FFCCC")]
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x06007D8D RID: 32141 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D8D")]
			[Address(RVA = "0x1C00040", Offset = "0x1C00040", VA = "0x7BBC400040")]
			internal void <ShowMessage>b__0()
			{
			}

			// Token: 0x06007D8E RID: 32142 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D8E")]
			[Address(RVA = "0x1C00078", Offset = "0x1C00078", VA = "0x7BBC400078")]
			internal void <ShowMessage>b__1()
			{
			}

			// Token: 0x04009123 RID: 37155
			[Token(Token = "0x4009123")]
			[FieldOffset(Offset = "0x10")]
			public UIHudDriftBottleAddFriendController <>4__this;

			// Token: 0x04009124 RID: 37156
			[Token(Token = "0x4009124")]
			[FieldOffset(Offset = "0x18")]
			public float closeTime;
		}
	}
}
