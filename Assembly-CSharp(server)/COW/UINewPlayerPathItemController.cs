using System;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001AA0 RID: 6816
	[Token(Token = "0x2001AA0")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F8744", Offset = "0x10F8744")]
	public class UINewPlayerPathItemController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x06008FAB RID: 36779 RVA: 0x00026460 File Offset: 0x00024660
		// (set) Token: 0x06008FAA RID: 36778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009ED")]
		public int Index
		{
			[Token(Token = "0x6008FAB")]
			[Address(RVA = "0x1AF7B58", Offset = "0x1AF7B58", VA = "0x7BBC2F7B58")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11447F8", Offset = "0x11447F8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6008FAA")]
			[Address(RVA = "0x1AF7B50", Offset = "0x1AF7B50", VA = "0x7BBC2F7B50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11447E8", Offset = "0x11447E8")]
			private set
			{
			}
		}

		// Token: 0x06008FAC RID: 36780 RVA: 0x00026478 File Offset: 0x00024678
		[Token(Token = "0x6008FAC")]
		[Address(RVA = "0x1AF7B60", Offset = "0x1AF7B60", VA = "0x7BBC2F7B60")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008FAD RID: 36781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FAD")]
		[Address(RVA = "0x1AF7BB0", Offset = "0x1AF7BB0", VA = "0x7BBC2F7BB0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008FAE RID: 36782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FAE")]
		[Address(RVA = "0x1AF7E5C", Offset = "0x1AF7E5C", VA = "0x7BBC2F7E5C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008FAF RID: 36783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FAF")]
		[Address(RVA = "0x1AF7F24", Offset = "0x1AF7F24", VA = "0x7BBC2F7F24")]
		private void OnItemClick()
		{
		}

		// Token: 0x06008FB0 RID: 36784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FB0")]
		[Address(RVA = "0x1AF81F4", Offset = "0x1AF81F4", VA = "0x7BBC2F81F4")]
		private void OnClickPreview()
		{
		}

		// Token: 0x06008FB1 RID: 36785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FB1")]
		[Address(RVA = "0x1AF8570", Offset = "0x1AF8570", VA = "0x7BBC2F8570")]
		private void OnClickClaim()
		{
		}

		// Token: 0x06008FB2 RID: 36786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FB2")]
		[Address(RVA = "0x1AF51A0", Offset = "0x1AF51A0", VA = "0x7BBC2F51A0")]
		public void SetData(int index, ActivityInfo info)
		{
		}

		// Token: 0x06008FB3 RID: 36787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FB3")]
		[Address(RVA = "0x1AF85E8", Offset = "0x1AF85E8", VA = "0x7BBC2F85E8")]
		private void SetDayCountLabel(int dayID)
		{
		}

		// Token: 0x06008FB4 RID: 36788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FB4")]
		[Address(RVA = "0x1AF5110", Offset = "0x1AF5110", VA = "0x7BBC2F5110")]
		public void SetDragData(UIScrollView view)
		{
		}

		// Token: 0x06008FB5 RID: 36789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FB5")]
		[Address(RVA = "0x1AF8750", Offset = "0x1AF8750", VA = "0x7BBC2F8750")]
		private void UpdateView()
		{
		}

		// Token: 0x06008FB6 RID: 36790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FB6")]
		[Address(RVA = "0x1AF9234", Offset = "0x1AF9234", VA = "0x7BBC2F9234")]
		private void UpdateClaimState()
		{
		}

		// Token: 0x06008FB7 RID: 36791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FB7")]
		[Address(RVA = "0x1AF9704", Offset = "0x1AF9704", VA = "0x7BBC2F9704", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06008FB8 RID: 36792 RVA: 0x00026490 File Offset: 0x00024690
		[Token(Token = "0x6008FB8")]
		[Address(RVA = "0x1AF99FC", Offset = "0x1AF99FC", VA = "0x7BBC2F99FC", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06008FB9 RID: 36793 RVA: 0x000264A8 File Offset: 0x000246A8
		[Token(Token = "0x6008FB9")]
		[Address(RVA = "0x1AF95F0", Offset = "0x1AF95F0", VA = "0x7BBC2F95F0")]
		public Vector2 GetIntersection(Vector2 p0, float k0, Vector2 p1, float k1)
		{
			return default(Vector2);
		}

		// Token: 0x06008FBA RID: 36794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FBA")]
		[Address(RVA = "0x1AF9A40", Offset = "0x1AF9A40", VA = "0x7BBC2F9A40")]
		public UINewPlayerPathItemController()
		{
		}

		// Token: 0x06008FBB RID: 36795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FBB")]
		[Address(RVA = "0x1AF9A5C", Offset = "0x1AF9A5C", VA = "0x7BBC2F9A5C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144808", Offset = "0x1144808")]
		private void <UpdateView>b__19_0()
		{
		}

		// Token: 0x04009BC5 RID: 39877
		[Token(Token = "0x4009BC5")]
		[FieldOffset(Offset = "0x58")]
		private UINewPlayerPathItemView m_View;

		// Token: 0x04009BC6 RID: 39878
		[Token(Token = "0x4009BC6")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FA2C", Offset = "0x112FA2C")]
		private int <Index>k__BackingField;

		// Token: 0x04009BC7 RID: 39879
		[Token(Token = "0x4009BC7")]
		[FieldOffset(Offset = "0x68")]
		private ActivityInfo m_Info;

		// Token: 0x04009BC8 RID: 39880
		[Token(Token = "0x4009BC8")]
		[FieldOffset(Offset = "0x70")]
		private readonly uint m_GreyProgressColor;

		// Token: 0x04009BC9 RID: 39881
		[Token(Token = "0x4009BC9")]
		[FieldOffset(Offset = "0x74")]
		private readonly uint m_YellowProgressColor;

		// Token: 0x04009BCA RID: 39882
		[Token(Token = "0x4009BCA")]
		[FieldOffset(Offset = "0x78")]
		private UIModelNewPlayerPath m_ModelPath;

		// Token: 0x04009BCB RID: 39883
		[Token(Token = "0x4009BCB")]
		[FieldOffset(Offset = "0x80")]
		private uint m_TodayUnlockCall;

		// Token: 0x02001AA1 RID: 6817
		[Token(Token = "0x2001AA1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F877C", Offset = "0x10F877C")]
		private sealed class <>c__DisplayClass19_0
		{
			// Token: 0x06008FBC RID: 36796 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008FBC")]
			[Address(RVA = "0x1AF95E8", Offset = "0x1AF95E8", VA = "0x7BBC2F95E8")]
			public <>c__DisplayClass19_0()
			{
			}

			// Token: 0x06008FBD RID: 36797 RVA: 0x000264C0 File Offset: 0x000246C0
			[Token(Token = "0x6008FBD")]
			[Address(RVA = "0x1AF9AD4", Offset = "0x1AF9AD4", VA = "0x7BBC2F9AD4")]
			internal bool <UpdateView>b__1(ActivityInfo temp)
			{
				return default(bool);
			}

			// Token: 0x04009BCC RID: 39884
			[Token(Token = "0x4009BCC")]
			[FieldOffset(Offset = "0x10")]
			public uint subId;
		}
	}
}
