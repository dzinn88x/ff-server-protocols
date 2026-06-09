using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001AA5 RID: 6821
	[Token(Token = "0x2001AA5")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F880C", Offset = "0x10F880C")]
	public class UINewPlayerUpGradeController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06008FD7 RID: 36823 RVA: 0x00026538 File Offset: 0x00024738
		[Token(Token = "0x6008FD7")]
		[Address(RVA = "0x1AFCDDC", Offset = "0x1AFCDDC", VA = "0x7BBC2FCDDC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008FD8 RID: 36824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FD8")]
		[Address(RVA = "0x1AFCE2C", Offset = "0x1AFCE2C", VA = "0x7BBC2FCE2C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008FD9 RID: 36825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FD9")]
		[Address(RVA = "0x1AFD164", Offset = "0x1AFD164", VA = "0x7BBC2FD164", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06008FDA RID: 36826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FDA")]
		[Address(RVA = "0x1AFD1A4", Offset = "0x1AFD1A4", VA = "0x7BBC2FD1A4")]
		private void RefreshUI()
		{
		}

		// Token: 0x06008FDB RID: 36827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FDB")]
		[Address(RVA = "0x1AFD4C4", Offset = "0x1AFD4C4", VA = "0x7BBC2FD4C4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008FDC RID: 36828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FDC")]
		[Address(RVA = "0x1AFD504", Offset = "0x1AFD504", VA = "0x7BBC2FD504", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06008FDD RID: 36829 RVA: 0x00026550 File Offset: 0x00024750
		[Token(Token = "0x6008FDD")]
		[Address(RVA = "0x1AFD8A8", Offset = "0x1AFD8A8", VA = "0x7BBC2FD8A8", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06008FDE RID: 36830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FDE")]
		[Address(RVA = "0x1AFD8EC", Offset = "0x1AFD8EC", VA = "0x7BBC2FD8EC")]
		public UINewPlayerUpGradeController()
		{
		}

		// Token: 0x06008FDF RID: 36831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FDF")]
		[Address(RVA = "0x1AFD95C", Offset = "0x1AFD95C", VA = "0x7BBC2FD95C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144828", Offset = "0x1144828")]
		private void <OnUIInit>b__5_0()
		{
		}

		// Token: 0x04009BD8 RID: 39896
		[Token(Token = "0x4009BD8")]
		[FieldOffset(Offset = "0x58")]
		private List<UINewPlayerUpGradeItemController> m_ItemControllerList;

		// Token: 0x04009BD9 RID: 39897
		[Token(Token = "0x4009BD9")]
		[FieldOffset(Offset = "0x60")]
		private UINewPlayerUpGradeView m_View;

		// Token: 0x04009BDA RID: 39898
		[Token(Token = "0x4009BDA")]
		[FieldOffset(Offset = "0x68")]
		private UIModelNewPlayerUpGrade m_Model;

		// Token: 0x04009BDB RID: 39899
		[Token(Token = "0x4009BDB")]
		[FieldOffset(Offset = "0x70")]
		private UICountDownController m_CountDownCtrl;

		// Token: 0x02001AA6 RID: 6822
		[Token(Token = "0x2001AA6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F8844", Offset = "0x10F8844")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06008FE1 RID: 36833 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008FE1")]
			[Address(RVA = "0x1AFDA1C", Offset = "0x1AFDA1C", VA = "0x7BBC2FDA1C")]
			public <>c()
			{
			}

			// Token: 0x06008FE2 RID: 36834 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6008FE2")]
			[Address(RVA = "0x1AFDA24", Offset = "0x1AFDA24", VA = "0x7BBC2FDA24")]
			internal CommonRewardItemInfo <OnDataChanged>b__9_0(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x04009BDC RID: 39900
			[Token(Token = "0x4009BDC")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UINewPlayerUpGradeController.<>c <>9;

			// Token: 0x04009BDD RID: 39901
			[Token(Token = "0x4009BDD")]
			[FieldOffset(Offset = "0x8")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__9_0;
		}
	}
}
