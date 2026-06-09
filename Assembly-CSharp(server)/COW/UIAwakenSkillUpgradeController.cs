using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001439 RID: 5177
	[Token(Token = "0x2001439")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ECA80", Offset = "0x10ECA80")]
	public class UIAwakenSkillUpgradeController : UIPopupWindowController
	{
		// Token: 0x060055F0 RID: 22000 RVA: 0x00019980 File Offset: 0x00017B80
		[Token(Token = "0x60055F0")]
		[Address(RVA = "0x141C810", Offset = "0x141C810", VA = "0x7BBBC1C810")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060055F1 RID: 22001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055F1")]
		[Address(RVA = "0x141C860", Offset = "0x141C860", VA = "0x7BBBC1C860", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060055F2 RID: 22002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055F2")]
		[Address(RVA = "0x141C99C", Offset = "0x141C99C", VA = "0x7BBBC1C99C")]
		private void OnUpgradeBtn()
		{
		}

		// Token: 0x060055F3 RID: 22003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055F3")]
		[Address(RVA = "0x141C9EC", Offset = "0x141C9EC", VA = "0x7BBBC1C9EC")]
		public void SetData(uint avatarID)
		{
		}

		// Token: 0x060055F4 RID: 22004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055F4")]
		[Address(RVA = "0x141CA74", Offset = "0x141CA74", VA = "0x7BBBC1CA74")]
		private void SetSkillInfo(AvatarProfile ap)
		{
		}

		// Token: 0x060055F5 RID: 22005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055F5")]
		[Address(RVA = "0x141CD64", Offset = "0x141CD64", VA = "0x7BBBC1CD64")]
		private void SetConsumeUI(AvatarProfile ap)
		{
		}

		// Token: 0x060055F6 RID: 22006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055F6")]
		[Address(RVA = "0x141D318", Offset = "0x141D318", VA = "0x7BBBC1D318")]
		public UIAwakenSkillUpgradeController()
		{
		}

		// Token: 0x04007AB1 RID: 31409
		[Token(Token = "0x4007AB1")]
		[FieldOffset(Offset = "0x98")]
		private UIAwakenSkillUpgradeView m_View;

		// Token: 0x04007AB2 RID: 31410
		[Token(Token = "0x4007AB2")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelAvatarProfile m_Model;

		// Token: 0x04007AB3 RID: 31411
		[Token(Token = "0x4007AB3")]
		[FieldOffset(Offset = "0xA8")]
		private uint m_CurrentAvatarId;

		// Token: 0x04007AB4 RID: 31412
		[Token(Token = "0x4007AB4")]
		[FieldOffset(Offset = "0xB0")]
		private UIAvatarSkillSlotController m_skillSlotCtrl;
	}
}
