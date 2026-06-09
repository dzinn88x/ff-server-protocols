using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x0200170C RID: 5900
	[Token(Token = "0x200170C")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F158C", Offset = "0x10F158C")]
	public class UIChoose1From3Controller : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x06006DE6 RID: 28134 RVA: 0x0001EF60 File Offset: 0x0001D160
		[Token(Token = "0x6006DE6")]
		[Address(RVA = "0x1BF2528", Offset = "0x1BF2528", VA = "0x7BBC3F2528")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006DE7 RID: 28135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DE7")]
		[Address(RVA = "0x1BF2578", Offset = "0x1BF2578", VA = "0x7BBC3F2578", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006DE8 RID: 28136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DE8")]
		[Address(RVA = "0x1BF32D8", Offset = "0x1BF32D8", VA = "0x7BBC3F32D8", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06006DE9 RID: 28137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DE9")]
		[Address(RVA = "0x1BF3020", Offset = "0x1BF3020", VA = "0x7BBC3F3020")]
		private void ShowNameContent()
		{
		}

		// Token: 0x06006DEA RID: 28138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DEA")]
		[Address(RVA = "0x1BF3434", Offset = "0x1BF3434", VA = "0x7BBC3F3434")]
		private void OnSuccessfullyDownloadTitleCDN()
		{
		}

		// Token: 0x06006DEB RID: 28139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DEB")]
		[Address(RVA = "0x1BF34DC", Offset = "0x1BF34DC", VA = "0x7BBC3F34DC")]
		public void OnClickRecharge()
		{
		}

		// Token: 0x06006DEC RID: 28140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DEC")]
		[Address(RVA = "0x1BF3514", Offset = "0x1BF3514", VA = "0x7BBC3F3514")]
		public void OnClickClaim()
		{
		}

		// Token: 0x06006DED RID: 28141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DED")]
		[Address(RVA = "0x1BF2A28", Offset = "0x1BF2A28", VA = "0x7BBC3F2A28")]
		private void UpdateView()
		{
		}

		// Token: 0x06006DEE RID: 28142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DEE")]
		[Address(RVA = "0x1BF388C", Offset = "0x1BF388C", VA = "0x7BBC3F388C")]
		private void SetItemID(OptionalBundleShowData data)
		{
		}

		// Token: 0x06006DEF RID: 28143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DEF")]
		[Address(RVA = "0x1BF3B18", Offset = "0x1BF3B18", VA = "0x7BBC3F3B18", Slot = "21")]
		public override void Show()
		{
		}

		// Token: 0x06006DF0 RID: 28144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DF0")]
		[Address(RVA = "0x1BF3B40", Offset = "0x1BF3B40", VA = "0x7BBC3F3B40")]
		public void OpenPreview()
		{
		}

		// Token: 0x06006DF1 RID: 28145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DF1")]
		[Address(RVA = "0x1BF3A68", Offset = "0x1BF3A68", VA = "0x7BBC3F3A68")]
		private void ShowPreview()
		{
		}

		// Token: 0x06006DF2 RID: 28146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DF2")]
		[Address(RVA = "0x1BF3ED0", Offset = "0x1BF3ED0", VA = "0x7BBC3F3ED0")]
		public void SetPreviewInfo()
		{
		}

		// Token: 0x06006DF3 RID: 28147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DF3")]
		[Address(RVA = "0x1BF4140", Offset = "0x1BF4140", VA = "0x7BBC3F4140", Slot = "39")]
		public override void OnPopupWindowListChange()
		{
		}

		// Token: 0x06006DF4 RID: 28148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DF4")]
		[Address(RVA = "0x1BF44C0", Offset = "0x1BF44C0", VA = "0x7BBC3F44C0", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06006DF5 RID: 28149 RVA: 0x0001EF78 File Offset: 0x0001D178
		[Token(Token = "0x6006DF5")]
		[Address(RVA = "0x1BF4700", Offset = "0x1BF4700", VA = "0x7BBC3F4700", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06006DF6 RID: 28150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DF6")]
		[Address(RVA = "0x1BF4764", Offset = "0x1BF4764", VA = "0x7BBC3F4764")]
		private void OnCountDownEnd()
		{
		}

		// Token: 0x06006DF7 RID: 28151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DF7")]
		[Address(RVA = "0x1BF4810", Offset = "0x1BF4810", VA = "0x7BBC3F4810")]
		public UIChoose1From3Controller()
		{
		}

		// Token: 0x040088BC RID: 35004
		[Token(Token = "0x40088BC")]
		[FieldOffset(Offset = "0x98")]
		private UIModelIAPBundle m_ModelBundle;

		// Token: 0x040088BD RID: 35005
		[Token(Token = "0x40088BD")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelActivity m_ModelActivity;

		// Token: 0x040088BE RID: 35006
		[Token(Token = "0x40088BE")]
		[FieldOffset(Offset = "0xA8")]
		private UIModelMall m_ModelMall;

		// Token: 0x040088BF RID: 35007
		[Token(Token = "0x40088BF")]
		[FieldOffset(Offset = "0xB0")]
		private UIChoose1From3View m_View;

		// Token: 0x040088C0 RID: 35008
		[Token(Token = "0x40088C0")]
		[FieldOffset(Offset = "0xB8")]
		private UIRoot m_UIRoot;

		// Token: 0x040088C1 RID: 35009
		[Token(Token = "0x40088C1")]
		[FieldOffset(Offset = "0xC0")]
		private uint m_ItemID;

		// Token: 0x040088C2 RID: 35010
		[Token(Token = "0x40088C2")]
		[FieldOffset(Offset = "0xC8")]
		private List<UIChoose1From3ItemController> m_Items;

		// Token: 0x040088C3 RID: 35011
		[Token(Token = "0x40088C3")]
		[FieldOffset(Offset = "0xD0")]
		private Transform[] m_ItemRoots;

		// Token: 0x040088C4 RID: 35012
		[Token(Token = "0x40088C4")]
		[FieldOffset(Offset = "0xD8")]
		private OptionalBundleShowData m_CurData;

		// Token: 0x040088C5 RID: 35013
		[Token(Token = "0x40088C5")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_PreviewCameraCovered;

		// Token: 0x040088C6 RID: 35014
		[Token(Token = "0x40088C6")]
		[FieldOffset(Offset = "0xE4")]
		private PreViewManager.Cameratype m_PreViewCameraType;

		// Token: 0x040088C7 RID: 35015
		[Token(Token = "0x40088C7")]
		[FieldOffset(Offset = "0xE8")]
		private ShowBoostAvatarParams showBoostAvatarParams;

		// Token: 0x040088C8 RID: 35016
		[Token(Token = "0x40088C8")]
		[FieldOffset(Offset = "0xF0")]
		private bool isItemABReady;

		// Token: 0x040088C9 RID: 35017
		[Token(Token = "0x40088C9")]
		[FieldOffset(Offset = "0xF4")]
		private uint m_BundleID;

		// Token: 0x0200170D RID: 5901
		[Token(Token = "0x200170D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F15C4", Offset = "0x10F15C4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006DF9 RID: 28153 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006DF9")]
			[Address(RVA = "0x1BF48E4", Offset = "0x1BF48E4", VA = "0x7BBC3F48E4")]
			public <>c()
			{
			}

			// Token: 0x06006DFA RID: 28154 RVA: 0x0001EF90 File Offset: 0x0001D190
			[Token(Token = "0x6006DFA")]
			[Address(RVA = "0x1BF48EC", Offset = "0x1BF48EC", VA = "0x7BBC3F48EC")]
			internal bool <ShowNameContent>b__17_0(AdvertDesc x)
			{
				return default(bool);
			}

			// Token: 0x040088CA RID: 35018
			[Token(Token = "0x40088CA")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIChoose1From3Controller.<>c <>9;

			// Token: 0x040088CB RID: 35019
			[Token(Token = "0x40088CB")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<AdvertDesc> <>9__17_0;
		}
	}
}
