using System;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001AA4 RID: 6820
	[Token(Token = "0x2001AA4")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F87D4", Offset = "0x10F87D4")]
	public class UINewPlayerSigninItemController : UIBaseController
	{
		// Token: 0x06008FCA RID: 36810 RVA: 0x00026508 File Offset: 0x00024708
		[Token(Token = "0x6008FCA")]
		[Address(RVA = "0x1AFB818", Offset = "0x1AFB818", VA = "0x7BBC2FB818")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x170009EE RID: 2542
		// (set) Token: 0x06008FCB RID: 36811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009EE")]
		public bool IsVeteran
		{
			[Token(Token = "0x6008FCB")]
			[Address(RVA = "0x1AFB868", Offset = "0x1AFB868", VA = "0x7BBC2FB868")]
			set
			{
			}
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x06008FCC RID: 36812 RVA: 0x00026520 File Offset: 0x00024720
		// (set) Token: 0x06008FCD RID: 36813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009EF")]
		public Vector2 ItemSize
		{
			[Token(Token = "0x6008FCC")]
			[Address(RVA = "0x1AFB874", Offset = "0x1AFB874", VA = "0x7BBC2FB874")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6008FCD")]
			[Address(RVA = "0x1AFB9CC", Offset = "0x1AFB9CC", VA = "0x7BBC2FB9CC")]
			set
			{
			}
		}

		// Token: 0x06008FCE RID: 36814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FCE")]
		[Address(RVA = "0x1AFBAFC", Offset = "0x1AFBAFC", VA = "0x7BBC2FBAFC")]
		private void SetBGSize(Vector2 size)
		{
		}

		// Token: 0x06008FCF RID: 36815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FCF")]
		[Address(RVA = "0x1AFBB00", Offset = "0x1AFBB00", VA = "0x7BBC2FBB00", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008FD0 RID: 36816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FD0")]
		[Address(RVA = "0x1AFBBE4", Offset = "0x1AFBBE4", VA = "0x7BBC2FBBE4")]
		private void OnItemClick()
		{
		}

		// Token: 0x06008FD1 RID: 36817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FD1")]
		[Address(RVA = "0x1AFBD00", Offset = "0x1AFBD00", VA = "0x7BBC2FBD00")]
		public void SetRewardData(VeteranRewardItem item, int listIndex, bool isLastOne = false)
		{
		}

		// Token: 0x06008FD2 RID: 36818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FD2")]
		[Address(RVA = "0x1AFB070", Offset = "0x1AFB070", VA = "0x7BBC2FB070")]
		public void SetRewardData(AttendaceItemInfo attendanceInfo, int listIndex, bool isLastOne = false)
		{
		}

		// Token: 0x06008FD3 RID: 36819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FD3")]
		[Address(RVA = "0x1AFBED4", Offset = "0x1AFBED4", VA = "0x7BBC2FBED4")]
		private void SetDayCountLabel(uint dayID)
		{
		}

		// Token: 0x06008FD4 RID: 36820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FD4")]
		[Address(RVA = "0x1AFC278", Offset = "0x1AFC278", VA = "0x7BBC2FC278")]
		private void AdjustView(AwardItemInfo awardInfo, bool isLastOne = false)
		{
		}

		// Token: 0x06008FD5 RID: 36821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FD5")]
		[Address(RVA = "0x1AFC5C4", Offset = "0x1AFC5C4", VA = "0x7BBC2FC5C4")]
		public UINewPlayerSigninItemController()
		{
		}

		// Token: 0x04009BD3 RID: 39891
		[Token(Token = "0x4009BD3")]
		[FieldOffset(Offset = "0x0")]
		private static Vector3 SPECIAL_INFO_POS;

		// Token: 0x04009BD4 RID: 39892
		[Token(Token = "0x4009BD4")]
		[FieldOffset(Offset = "0x58")]
		private UIVeteranSigninItemView m_View;

		// Token: 0x04009BD5 RID: 39893
		[Token(Token = "0x4009BD5")]
		[FieldOffset(Offset = "0x60")]
		private UIWidget m_ItemWidget;

		// Token: 0x04009BD6 RID: 39894
		[Token(Token = "0x4009BD6")]
		[FieldOffset(Offset = "0x68")]
		private int m_IndexInList;

		// Token: 0x04009BD7 RID: 39895
		[Token(Token = "0x4009BD7")]
		[FieldOffset(Offset = "0x6C")]
		private bool m_IsVeteran;
	}
}
