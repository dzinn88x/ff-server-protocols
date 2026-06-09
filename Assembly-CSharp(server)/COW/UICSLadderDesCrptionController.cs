using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200177B RID: 6011
	[Token(Token = "0x200177B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F2204", Offset = "0x10F2204")]
	public class UICSLadderDesCrptionController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x060071E4 RID: 29156 RVA: 0x0001FB30 File Offset: 0x0001DD30
		[Token(Token = "0x60071E4")]
		[Address(RVA = "0x1C22148", Offset = "0x1C22148", VA = "0x7BBC422148")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060071E5 RID: 29157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071E5")]
		[Address(RVA = "0x1C22198", Offset = "0x1C22198", VA = "0x7BBC422198", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060071E6 RID: 29158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071E6")]
		[Address(RVA = "0x1C222A4", Offset = "0x1C222A4", VA = "0x7BBC4222A4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060071E7 RID: 29159 RVA: 0x0001FB48 File Offset: 0x0001DD48
		[Token(Token = "0x60071E7")]
		[Address(RVA = "0x1C22358", Offset = "0x1C22358", VA = "0x7BBC422358", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060071E8 RID: 29160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071E8")]
		[Address(RVA = "0x1C2239C", Offset = "0x1C2239C", VA = "0x7BBC42239C", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060071E9 RID: 29161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071E9")]
		[Address(RVA = "0x1C22414", Offset = "0x1C22414", VA = "0x7BBC422414")]
		private void UpdateDesInfo()
		{
		}

		// Token: 0x060071EA RID: 29162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071EA")]
		[Address(RVA = "0x1C22780", Offset = "0x1C22780", VA = "0x7BBC422780")]
		public UICSLadderDesCrptionController()
		{
		}

		// Token: 0x04008B32 RID: 35634
		[Token(Token = "0x4008B32")]
		[FieldOffset(Offset = "0x98")]
		private UICSLadderDescriptionView m_View;
	}
}
