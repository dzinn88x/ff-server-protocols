using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001683 RID: 5763
	[Token(Token = "0x2001683")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F047C", Offset = "0x10F047C")]
	public class UIHudFriendAddController : UIBaseController
	{
		// Token: 0x060068AC RID: 26796 RVA: 0x0001DAC0 File Offset: 0x0001BCC0
		[Token(Token = "0x60068AC")]
		[Address(RVA = "0x1C0F474", Offset = "0x1C0F474", VA = "0x7BBC40F474")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060068AD RID: 26797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068AD")]
		[Address(RVA = "0x1C0F4C4", Offset = "0x1C0F4C4", VA = "0x7BBC40F4C4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060068AE RID: 26798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068AE")]
		[Address(RVA = "0x1C0F69C", Offset = "0x1C0F69C", VA = "0x7BBC40F69C")]
		public void BindPlayer({QAb\u0082~u player_id)
		{
		}

		// Token: 0x060068AF RID: 26799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068AF")]
		[Address(RVA = "0x1C0FA4C", Offset = "0x1C0FA4C", VA = "0x7BBC40FA4C")]
		private void onAddBtnClicked()
		{
		}

		// Token: 0x060068B0 RID: 26800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068B0")]
		[Address(RVA = "0x1C0FBBC", Offset = "0x1C0FBBC", VA = "0x7BBC40FBBC")]
		public UIHudFriendAddController()
		{
		}

		// Token: 0x060068B1 RID: 26801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068B1")]
		[Address(RVA = "0x1C0FBC4", Offset = "0x1C0FBC4", VA = "0x7BBC40FBC4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1140B3C", Offset = "0x1140B3C")]
		private void <BindPlayer>b__7_0()
		{
		}

		// Token: 0x04008557 RID: 34135
		[Token(Token = "0x4008557")]
		[FieldOffset(Offset = "0x58")]
		private UIHudFriendaddView m_View;

		// Token: 0x04008558 RID: 34136
		[Token(Token = "0x4008558")]
		[FieldOffset(Offset = "0x60")]
		private UIBaseProfileInfoController m_Profile;

		// Token: 0x04008559 RID: 34137
		[Token(Token = "0x4008559")]
		[FieldOffset(Offset = "0x68")]
		private ulong m_BindAccountID;

		// Token: 0x0400855A RID: 34138
		[Token(Token = "0x400855A")]
		[FieldOffset(Offset = "0x70")]
		private bool m_IsFriend;

		// Token: 0x0400855B RID: 34139
		[Token(Token = "0x400855B")]
		[FieldOffset(Offset = "0x74")]
		private uint m_DelayCallID;
	}
}
