using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020013D3 RID: 5075
	[Token(Token = "0x20013D3")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EBFC8", Offset = "0x10EBFC8")]
	public class UISuperFighterMissionWndController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x06005326 RID: 21286 RVA: 0x00018DB0 File Offset: 0x00016FB0
		[Token(Token = "0x6005326")]
		[Address(RVA = "0x1F4D880", Offset = "0x1F4D880", VA = "0x7BBC74D880")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005327 RID: 21287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005327")]
		[Address(RVA = "0x1F4D8D0", Offset = "0x1F4D8D0", VA = "0x7BBC74D8D0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005328 RID: 21288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005328")]
		[Address(RVA = "0x1F4D9D4", Offset = "0x1F4D9D4", VA = "0x7BBC74D9D4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005329 RID: 21289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005329")]
		[Address(RVA = "0x1F4DA14", Offset = "0x1F4DA14", VA = "0x7BBC74DA14", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x0600532A RID: 21290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600532A")]
		[Address(RVA = "0x1F4DA3C", Offset = "0x1F4DA3C", VA = "0x7BBC74DA3C")]
		private void SetView()
		{
		}

		// Token: 0x0600532B RID: 21291 RVA: 0x00018DC8 File Offset: 0x00016FC8
		[Token(Token = "0x600532B")]
		[Address(RVA = "0x1F4DE74", Offset = "0x1F4DE74", VA = "0x7BBC74DE74", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600532C RID: 21292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600532C")]
		[Address(RVA = "0x1F4DEB8", Offset = "0x1F4DEB8", VA = "0x7BBC74DEB8", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600532D RID: 21293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600532D")]
		[Address(RVA = "0x1F4DF30", Offset = "0x1F4DF30", VA = "0x7BBC74DF30")]
		public UISuperFighterMissionWndController()
		{
		}

		// Token: 0x040078E6 RID: 30950
		[Token(Token = "0x40078E6")]
		[FieldOffset(Offset = "0x98")]
		private UISuperFighterMissionWndView m_View;

		// Token: 0x040078E7 RID: 30951
		[Token(Token = "0x40078E7")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelSuperFighter m_ModelSuperFighter;

		// Token: 0x040078E8 RID: 30952
		[Token(Token = "0x40078E8")]
		[FieldOffset(Offset = "0xA8")]
		private UIModelActivity m_ModelActivity;

		// Token: 0x040078E9 RID: 30953
		[Token(Token = "0x40078E9")]
		private const uint MISSION_CNT = 4U;
	}
}
