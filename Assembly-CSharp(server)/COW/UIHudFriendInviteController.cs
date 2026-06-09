using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001684 RID: 5764
	[Token(Token = "0x2001684")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F04B4", Offset = "0x10F04B4")]
	public class UIHudFriendInviteController : UIBaseController
	{
		// Token: 0x060068B2 RID: 26802 RVA: 0x0001DAD8 File Offset: 0x0001BCD8
		[Token(Token = "0x60068B2")]
		[Address(RVA = "0x1C0FBE0", Offset = "0x1C0FBE0", VA = "0x7BBC40FBE0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060068B3 RID: 26803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068B3")]
		[Address(RVA = "0x1C0FC30", Offset = "0x1C0FC30", VA = "0x7BBC40FC30", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060068B4 RID: 26804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068B4")]
		[Address(RVA = "0x1C0FE50", Offset = "0x1C0FE50", VA = "0x7BBC40FE50")]
		public void BindPlayer(ulong user_id)
		{
		}

		// Token: 0x060068B5 RID: 26805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068B5")]
		[Address(RVA = "0x1C101F8", Offset = "0x1C101F8", VA = "0x7BBC4101F8")]
		private void OnAgreeBtnClick()
		{
		}

		// Token: 0x060068B6 RID: 26806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068B6")]
		[Address(RVA = "0x1C10420", Offset = "0x1C10420", VA = "0x7BBC410420")]
		private void OnDisAgreeBtnClick()
		{
		}

		// Token: 0x060068B7 RID: 26807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068B7")]
		[Address(RVA = "0x1C10360", Offset = "0x1C10360", VA = "0x7BBC410360")]
		private void OnInviteChecked()
		{
		}

		// Token: 0x060068B8 RID: 26808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068B8")]
		[Address(RVA = "0x1C10588", Offset = "0x1C10588", VA = "0x7BBC410588")]
		private void OnIgnoreToggleClick()
		{
		}

		// Token: 0x060068B9 RID: 26809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068B9")]
		[Address(RVA = "0x1C105EC", Offset = "0x1C105EC", VA = "0x7BBC4105EC")]
		public UIHudFriendInviteController()
		{
		}

		// Token: 0x060068BA RID: 26810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068BA")]
		[Address(RVA = "0x1C105F4", Offset = "0x1C105F4", VA = "0x7BBC4105F4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1140B4C", Offset = "0x1140B4C")]
		private void <BindPlayer>b__9_0()
		{
		}

		// Token: 0x060068BB RID: 26811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068BB")]
		[Address(RVA = "0x1C105FC", Offset = "0x1C105FC", VA = "0x7BBC4105FC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1140B5C", Offset = "0x1140B5C")]
		private void <BindPlayer>b__9_1()
		{
		}

		// Token: 0x0400855C RID: 34140
		[Token(Token = "0x400855C")]
		[FieldOffset(Offset = "0x58")]
		private UIHudFriendinviteView m_View;

		// Token: 0x0400855D RID: 34141
		[Token(Token = "0x400855D")]
		[FieldOffset(Offset = "0x60")]
		private UIModelFriends m_Model;

		// Token: 0x0400855E RID: 34142
		[Token(Token = "0x400855E")]
		[FieldOffset(Offset = "0x68")]
		private bool m_IsIgnore;

		// Token: 0x0400855F RID: 34143
		[Token(Token = "0x400855F")]
		[FieldOffset(Offset = "0x6C")]
		private uint m_CloseDelayCallID;

		// Token: 0x04008560 RID: 34144
		[Token(Token = "0x4008560")]
		[FieldOffset(Offset = "0x70")]
		private uint m_TimeDelayCallID;

		// Token: 0x04008561 RID: 34145
		[Token(Token = "0x4008561")]
		[FieldOffset(Offset = "0x78")]
		private ulong m_AutoDisagreeTimeStamp;

		// Token: 0x04008562 RID: 34146
		[Token(Token = "0x4008562")]
		[FieldOffset(Offset = "0x80")]
		private ulong m_BindUserID;
	}
}
