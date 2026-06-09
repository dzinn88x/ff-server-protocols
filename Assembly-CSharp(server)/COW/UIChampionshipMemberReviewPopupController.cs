using System;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001480 RID: 5248
	[Token(Token = "0x2001480")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ECF9C", Offset = "0x10ECF9C")]
	public class UIChampionshipMemberReviewPopupController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x06005890 RID: 22672 RVA: 0x0001A1A8 File Offset: 0x000183A8
		[Token(Token = "0x6005890")]
		[Address(RVA = "0x1EC578C", Offset = "0x1EC578C", VA = "0x7BBC6C578C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005891 RID: 22673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005891")]
		[Address(RVA = "0x1EC57DC", Offset = "0x1EC57DC", VA = "0x7BBC6C57DC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005892 RID: 22674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005892")]
		[Address(RVA = "0x1EC5BB0", Offset = "0x1EC5BB0", VA = "0x7BBC6C5BB0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005893 RID: 22675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005893")]
		[Address(RVA = "0x1EC5BF0", Offset = "0x1EC5BF0", VA = "0x7BBC6C5BF0")]
		public void SetInviteView(uint championshipType)
		{
		}

		// Token: 0x06005894 RID: 22676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005894")]
		[Address(RVA = "0x1EC5ED8", Offset = "0x1EC5ED8", VA = "0x7BBC6C5ED8")]
		public void SetChampionshipType(uint championshipType)
		{
		}

		// Token: 0x06005895 RID: 22677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005895")]
		[Address(RVA = "0x1EC5EE0", Offset = "0x1EC5EE0", VA = "0x7BBC6C5EE0")]
		public void SetApplyAndInviteView()
		{
		}

		// Token: 0x06005896 RID: 22678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005896")]
		[Address(RVA = "0x1EC60A0", Offset = "0x1EC60A0", VA = "0x7BBC6C60A0")]
		private void ShowApplyPage()
		{
		}

		// Token: 0x06005897 RID: 22679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005897")]
		[Address(RVA = "0x1EC5DB8", Offset = "0x1EC5DB8", VA = "0x7BBC6C5DB8")]
		private void ShowInvitePage()
		{
		}

		// Token: 0x06005898 RID: 22680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005898")]
		[Address(RVA = "0x1EC61C0", Offset = "0x1EC61C0", VA = "0x7BBC6C61C0")]
		private void RejectAllApply()
		{
		}

		// Token: 0x06005899 RID: 22681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005899")]
		[Address(RVA = "0x1EC6330", Offset = "0x1EC6330", VA = "0x7BBC6C6330")]
		private void RejectAllInvite()
		{
		}

		// Token: 0x0600589A RID: 22682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600589A")]
		[Address(RVA = "0x1EC64A0", Offset = "0x1EC64A0", VA = "0x7BBC6C64A0")]
		private void UpdateInvitation()
		{
		}

		// Token: 0x0600589B RID: 22683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600589B")]
		[Address(RVA = "0x1EC65B8", Offset = "0x1EC65B8", VA = "0x7BBC6C65B8")]
		private void UpdateApplicant()
		{
		}

		// Token: 0x0600589C RID: 22684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600589C")]
		[Address(RVA = "0x1EC66D0", Offset = "0x1EC66D0", VA = "0x7BBC6C66D0", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600589D RID: 22685 RVA: 0x0001A1C0 File Offset: 0x000183C0
		[Token(Token = "0x600589D")]
		[Address(RVA = "0x1EC67D0", Offset = "0x1EC67D0", VA = "0x7BBC6C67D0", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600589E RID: 22686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600589E")]
		[Address(RVA = "0x1EC6870", Offset = "0x1EC6870", VA = "0x7BBC6C6870")]
		public UIChampionshipMemberReviewPopupController()
		{
		}

		// Token: 0x04007C69 RID: 31849
		[Token(Token = "0x4007C69")]
		[FieldOffset(Offset = "0x98")]
		private UIChampionshipMemberReviewPopupView m_View;

		// Token: 0x04007C6A RID: 31850
		[Token(Token = "0x4007C6A")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelChampionship m_ModelChampionship;

		// Token: 0x04007C6B RID: 31851
		[Token(Token = "0x4007C6B")]
		[FieldOffset(Offset = "0xA8")]
		protected UIChampionshipMemberReviewPopupController.ApplyEasyListFacotry m_ApplyEasyListFactory;

		// Token: 0x04007C6C RID: 31852
		[Token(Token = "0x4007C6C")]
		[FieldOffset(Offset = "0xB0")]
		protected UIChampionshipMemberReviewPopupController.InviteEasyListFacotry m_InviteEasyListFactory;

		// Token: 0x04007C6D RID: 31853
		[Token(Token = "0x4007C6D")]
		[FieldOffset(Offset = "0xB8")]
		private uint m_ChampionshipType;

		// Token: 0x04007C6E RID: 31854
		[Token(Token = "0x4007C6E")]
		private const string TabApply = "TabApply";

		// Token: 0x04007C6F RID: 31855
		[Token(Token = "0x4007C6F")]
		private const string TabInvite = "TabInvite";

		// Token: 0x02001481 RID: 5249
		[Token(Token = "0x2001481")]
		public class ApplyEasyListFacotry : IEasyList
		{
			// Token: 0x0600589F RID: 22687 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600589F")]
			[Address(RVA = "0x1EC5B58", Offset = "0x1EC5B58", VA = "0x7BBC6C5B58")]
			public ApplyEasyListFacotry(UIChampionshipMemberReviewPopupController teamProfile)
			{
			}

			// Token: 0x060058A0 RID: 22688 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60058A0")]
			[Address(RVA = "0x1EC693C", Offset = "0x1EC693C", VA = "0x7BBC6C693C", Slot = "5")]
			public void CloseItemController(UIEasyListItemController itemController)
			{
			}

			// Token: 0x060058A1 RID: 22689 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60058A1")]
			[Address(RVA = "0x1EC696C", Offset = "0x1EC696C", VA = "0x7BBC6C696C", Slot = "4")]
			public UIEasyListItemController OpenItemController(Transform parent)
			{
				return null;
			}

			// Token: 0x04007C70 RID: 31856
			[Token(Token = "0x4007C70")]
			[FieldOffset(Offset = "0x10")]
			private UIChampionshipMemberReviewPopupController teamProfile;
		}

		// Token: 0x02001482 RID: 5250
		[Token(Token = "0x2001482")]
		public class InviteEasyListFacotry : IEasyList
		{
			// Token: 0x060058A2 RID: 22690 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60058A2")]
			[Address(RVA = "0x1EC5B84", Offset = "0x1EC5B84", VA = "0x7BBC6C5B84")]
			public InviteEasyListFacotry(UIChampionshipMemberReviewPopupController teamProfile)
			{
			}

			// Token: 0x060058A3 RID: 22691 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60058A3")]
			[Address(RVA = "0x1EC6AB0", Offset = "0x1EC6AB0", VA = "0x7BBC6C6AB0", Slot = "5")]
			public void CloseItemController(UIEasyListItemController itemController)
			{
			}

			// Token: 0x060058A4 RID: 22692 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60058A4")]
			[Address(RVA = "0x1EC6AE0", Offset = "0x1EC6AE0", VA = "0x7BBC6C6AE0", Slot = "4")]
			public UIEasyListItemController OpenItemController(Transform parent)
			{
				return null;
			}

			// Token: 0x04007C71 RID: 31857
			[Token(Token = "0x4007C71")]
			[FieldOffset(Offset = "0x10")]
			private UIChampionshipMemberReviewPopupController teamProfile;
		}

		// Token: 0x02001483 RID: 5251
		[Token(Token = "0x2001483")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10ECFD4", Offset = "0x10ECFD4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060058A6 RID: 22694 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60058A6")]
			[Address(RVA = "0x1EC68DC", Offset = "0x1EC68DC", VA = "0x7BBC6C68DC")]
			public <>c()
			{
			}

			// Token: 0x060058A7 RID: 22695 RVA: 0x0001A1D8 File Offset: 0x000183D8
			[Token(Token = "0x60058A7")]
			[Address(RVA = "0x1EC68E4", Offset = "0x1EC68E4", VA = "0x7BBC6C68E4")]
			internal ulong <RejectAllApply>b__17_0(AccountInfoBasic e)
			{
				return 0UL;
			}

			// Token: 0x060058A8 RID: 22696 RVA: 0x0001A1F0 File Offset: 0x000183F0
			[Token(Token = "0x60058A8")]
			[Address(RVA = "0x1EC6910", Offset = "0x1EC6910", VA = "0x7BBC6C6910")]
			internal ulong <RejectAllInvite>b__18_0(AccountInfoBasic e)
			{
				return 0UL;
			}

			// Token: 0x04007C72 RID: 31858
			[Token(Token = "0x4007C72")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIChampionshipMemberReviewPopupController.<>c <>9;

			// Token: 0x04007C73 RID: 31859
			[Token(Token = "0x4007C73")]
			[FieldOffset(Offset = "0x8")]
			public static Converter<AccountInfoBasic, ulong> <>9__17_0;

			// Token: 0x04007C74 RID: 31860
			[Token(Token = "0x4007C74")]
			[FieldOffset(Offset = "0x10")]
			public static Converter<AccountInfoBasic, ulong> <>9__18_0;
		}
	}
}
