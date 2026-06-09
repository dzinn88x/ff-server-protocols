using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001B9E RID: 7070
	[Token(Token = "0x2001B9E")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FA874", Offset = "0x10FA874")]
	internal class UISPHudTeamRankingListController : UIBaseController, IUIModelDataChangeObserver, IEasyList
	{
		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x06009894 RID: 39060 RVA: 0x000282D8 File Offset: 0x000264D8
		[Token(Token = "0x17000A48")]
		public UISPHudTeamRankingListController.EInfoType InfoType
		{
			[Token(Token = "0x6009894")]
			[Address(RVA = "0x1EFA3E4", Offset = "0x1EFA3E4", VA = "0x7BBC6FA3E4")]
			get
			{
				return UISPHudTeamRankingListController.EInfoType.ENone;
			}
		}

		// Token: 0x06009895 RID: 39061 RVA: 0x000282F0 File Offset: 0x000264F0
		[Token(Token = "0x6009895")]
		[Address(RVA = "0x1EFA92C", Offset = "0x1EFA92C", VA = "0x7BBC6FA92C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009896 RID: 39062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009896")]
		[Address(RVA = "0x1EFA97C", Offset = "0x1EFA97C", VA = "0x7BBC6FA97C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009897 RID: 39063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009897")]
		[Address(RVA = "0x1EFAC38", Offset = "0x1EFAC38", VA = "0x7BBC6FAC38", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009898 RID: 39064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009898")]
		[Address(RVA = "0x1EFAD24", Offset = "0x1EFAD24", VA = "0x7BBC6FAD24")]
		private void OnTogglePanel(params object[] data)
		{
		}

		// Token: 0x06009899 RID: 39065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009899")]
		[Address(RVA = "0x1EFB290", Offset = "0x1EFB290", VA = "0x7BBC6FB290", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600989A RID: 39066 RVA: 0x00028308 File Offset: 0x00026508
		[Token(Token = "0x600989A")]
		[Address(RVA = "0x1EFB630", Offset = "0x1EFB630", VA = "0x7BBC6FB630", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600989B RID: 39067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600989B")]
		[Address(RVA = "0x1EFB674", Offset = "0x1EFB674", VA = "0x7BBC6FB674", Slot = "30")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x0600989C RID: 39068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600989C")]
		[Address(RVA = "0x1EFB720", Offset = "0x1EFB720", VA = "0x7BBC6FB720", Slot = "31")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x0600989D RID: 39069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600989D")]
		[Address(RVA = "0x1EFB750", Offset = "0x1EFB750", VA = "0x7BBC6FB750")]
		public UISPHudTeamRankingListController()
		{
		}

		// Token: 0x0400A03F RID: 41023
		[Token(Token = "0x400A03F")]
		[FieldOffset(Offset = "0x58")]
		private UISPHudTeamRankingListView m_View;

		// Token: 0x0400A040 RID: 41024
		[Token(Token = "0x400A040")]
		[FieldOffset(Offset = "0x60")]
		private UIModelSpectator m_Model;

		// Token: 0x0400A041 RID: 41025
		[Token(Token = "0x400A041")]
		[FieldOffset(Offset = "0x68")]
		private bool m_IsCombatLevelRequesting;

		// Token: 0x0400A042 RID: 41026
		[Token(Token = "0x400A042")]
		[FieldOffset(Offset = "0x6C")]
		private UISPHudTeamRankingListController.EInfoType m_PrevType;

		// Token: 0x0400A043 RID: 41027
		[Token(Token = "0x400A043")]
		[FieldOffset(Offset = "0x70")]
		private UISPHudTeamRankingListController.EInfoType m_InfoType;

		// Token: 0x0400A044 RID: 41028
		[Token(Token = "0x400A044")]
		[FieldOffset(Offset = "0x74")]
		private float m_CachedY;

		// Token: 0x0400A045 RID: 41029
		[Token(Token = "0x400A045")]
		[FieldOffset(Offset = "0x78")]
		private Vector3 m_CachedNormalPos;

		// Token: 0x0400A046 RID: 41030
		[Token(Token = "0x400A046")]
		[FieldOffset(Offset = "0x84")]
		private Vector3 m_CachedCombatPos;

		// Token: 0x02001B9F RID: 7071
		[Token(Token = "0x2001B9F")]
		public enum EInfoType
		{
			// Token: 0x0400A048 RID: 41032
			[Token(Token = "0x400A048")]
			ENone,
			// Token: 0x0400A049 RID: 41033
			[Token(Token = "0x400A049")]
			ENormal,
			// Token: 0x0400A04A RID: 41034
			[Token(Token = "0x400A04A")]
			ECombatLevel
		}
	}
}
