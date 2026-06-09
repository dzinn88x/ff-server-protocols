using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020017D7 RID: 6103
	[Token(Token = "0x20017D7")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F2E34", Offset = "0x10F2E34")]
	internal class UIFullScreenPreviewController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x0600759D RID: 30109 RVA: 0x00020A48 File Offset: 0x0001EC48
		[Token(Token = "0x600759D")]
		[Address(RVA = "0x214DE6C", Offset = "0x214DE6C", VA = "0x7BBC94DE6C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600759E RID: 30110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600759E")]
		[Address(RVA = "0x214DEBC", Offset = "0x214DEBC", VA = "0x7BBC94DEBC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600759F RID: 30111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600759F")]
		[Address(RVA = "0x214E0A8", Offset = "0x214E0A8", VA = "0x7BBC94E0A8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060075A0 RID: 30112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075A0")]
		[Address(RVA = "0x214E15C", Offset = "0x214E15C", VA = "0x7BBC94E15C")]
		private void RefreshBG()
		{
		}

		// Token: 0x060075A1 RID: 30113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075A1")]
		[Address(RVA = "0x214E3C4", Offset = "0x214E3C4", VA = "0x7BBC94E3C4")]
		public void SetPreviewInfo(uint itemID)
		{
		}

		// Token: 0x060075A2 RID: 30114 RVA: 0x00020A60 File Offset: 0x0001EC60
		[Token(Token = "0x60075A2")]
		[Address(RVA = "0x214E58C", Offset = "0x214E58C", VA = "0x7BBC94E58C")]
		private BoostState CheckBoostStateDelegate(uint itemID)
		{
			return BoostState.DontChange;
		}

		// Token: 0x060075A3 RID: 30115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075A3")]
		[Address(RVA = "0x214E6F0", Offset = "0x214E6F0", VA = "0x7BBC94E6F0")]
		public void OpenPreview()
		{
		}

		// Token: 0x060075A4 RID: 30116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075A4")]
		[Address(RVA = "0x214EB74", Offset = "0x214EB74", VA = "0x7BBC94EB74", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060075A5 RID: 30117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075A5")]
		[Address(RVA = "0x214EC6C", Offset = "0x214EC6C", VA = "0x7BBC94EC6C", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x060075A6 RID: 30118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075A6")]
		[Address(RVA = "0x214ED2C", Offset = "0x214ED2C", VA = "0x7BBC94ED2C", Slot = "39")]
		public override void OnPopupWindowListChange()
		{
		}

		// Token: 0x060075A7 RID: 30119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075A7")]
		[Address(RVA = "0x214E2C0", Offset = "0x214E2C0", VA = "0x7BBC94E2C0")]
		private string GetCDNBgURLByType(uint itemID)
		{
			return null;
		}

		// Token: 0x060075A8 RID: 30120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075A8")]
		[Address(RVA = "0x214F0AC", Offset = "0x214F0AC", VA = "0x7BBC94F0AC")]
		private AdvertDesc GetAdvertDescByType(int type)
		{
			return null;
		}

		// Token: 0x060075A9 RID: 30121 RVA: 0x00020A78 File Offset: 0x0001EC78
		[Token(Token = "0x60075A9")]
		[Address(RVA = "0x214F1B0", Offset = "0x214F1B0", VA = "0x7BBC94F1B0", Slot = "34")]
		protected override bool UseCustomizedAnimation()
		{
			return default(bool);
		}

		// Token: 0x060075AA RID: 30122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075AA")]
		[Address(RVA = "0x214F1B8", Offset = "0x214F1B8", VA = "0x7BBC94F1B8", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060075AB RID: 30123 RVA: 0x00020A90 File Offset: 0x0001EC90
		[Token(Token = "0x60075AB")]
		[Address(RVA = "0x214F2A0", Offset = "0x214F2A0", VA = "0x7BBC94F2A0", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060075AC RID: 30124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075AC")]
		[Address(RVA = "0x214F2E4", Offset = "0x214F2E4", VA = "0x7BBC94F2E4")]
		public UIFullScreenPreviewController()
		{
		}

		// Token: 0x04008CF7 RID: 36087
		[Token(Token = "0x4008CF7")]
		[FieldOffset(Offset = "0x98")]
		private UIFullScreenPreviewView m_View;

		// Token: 0x04008CF8 RID: 36088
		[Token(Token = "0x4008CF8")]
		[FieldOffset(Offset = "0xA0")]
		private UIRoot m_UIRoot;

		// Token: 0x04008CF9 RID: 36089
		[Token(Token = "0x4008CF9")]
		[FieldOffset(Offset = "0xA8")]
		private uint m_ItemID;

		// Token: 0x04008CFA RID: 36090
		[Token(Token = "0x4008CFA")]
		[FieldOffset(Offset = "0xB0")]
		private UIModelCDNAd m_ModelCDNAd;

		// Token: 0x04008CFB RID: 36091
		[Token(Token = "0x4008CFB")]
		[FieldOffset(Offset = "0xB8")]
		private List<AdvertDesc> adList;

		// Token: 0x04008CFC RID: 36092
		[Token(Token = "0x4008CFC")]
		private const int DEFAULT = 1;

		// Token: 0x04008CFD RID: 36093
		[Token(Token = "0x4008CFD")]
		private const int PET = 2;

		// Token: 0x04008CFE RID: 36094
		[Token(Token = "0x4008CFE")]
		private const int WEAPON = 3;

		// Token: 0x04008CFF RID: 36095
		[Token(Token = "0x4008CFF")]
		[FieldOffset(Offset = "0xC0")]
		private PreViewManager.Cameratype m_PreViewCameraType;

		// Token: 0x04008D00 RID: 36096
		[Token(Token = "0x4008D00")]
		[FieldOffset(Offset = "0xC4")]
		private bool m_PreviewCameraCovered;

		// Token: 0x04008D01 RID: 36097
		[Token(Token = "0x4008D01")]
		[FieldOffset(Offset = "0xC8")]
		private ShowBoostAvatarParams showBoostAvatarParams;

		// Token: 0x04008D02 RID: 36098
		[Token(Token = "0x4008D02")]
		[FieldOffset(Offset = "0xD0")]
		private bool isItemABReady;

		// Token: 0x020017D8 RID: 6104
		[Token(Token = "0x20017D8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F2E6C", Offset = "0x10F2E6C")]
		private sealed class <>c__DisplayClass23_0
		{
			// Token: 0x060075AD RID: 30125 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60075AD")]
			[Address(RVA = "0x214F1A8", Offset = "0x214F1A8", VA = "0x7BBC94F1A8")]
			public <>c__DisplayClass23_0()
			{
			}

			// Token: 0x060075AE RID: 30126 RVA: 0x00020AA8 File Offset: 0x0001ECA8
			[Token(Token = "0x60075AE")]
			[Address(RVA = "0x214F2EC", Offset = "0x214F2EC", VA = "0x7BBC94F2EC")]
			internal bool <GetAdvertDescByType>b__0(AdvertDesc ad)
			{
				return default(bool);
			}

			// Token: 0x04008D03 RID: 36099
			[Token(Token = "0x4008D03")]
			[FieldOffset(Offset = "0x10")]
			public int type;
		}
	}
}
