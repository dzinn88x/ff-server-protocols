using System;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x0200149C RID: 5276
	[Token(Token = "0x200149C")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED334", Offset = "0x10ED334")]
	public class UIChampionshipTeamMemberItemController : UIEasyListItemController
	{
		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x0600595A RID: 22874 RVA: 0x0001A4D8 File Offset: 0x000186D8
		// (set) Token: 0x0600595B RID: 22875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008A1")]
		public bool ShowPresence
		{
			[Token(Token = "0x600595A")]
			[Address(RVA = "0x1ED4A5C", Offset = "0x1ED4A5C", VA = "0x7BBC6D4A5C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113F4C8", Offset = "0x113F4C8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600595B")]
			[Address(RVA = "0x1ED4A64", Offset = "0x1ED4A64", VA = "0x7BBC6D4A64")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113F4D8", Offset = "0x113F4D8")]
			set
			{
			}
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x0600595C RID: 22876 RVA: 0x0001A4F0 File Offset: 0x000186F0
		// (set) Token: 0x0600595D RID: 22877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008A2")]
		public bool ShowPopupMenu
		{
			[Token(Token = "0x600595C")]
			[Address(RVA = "0x1ED4A70", Offset = "0x1ED4A70", VA = "0x7BBC6D4A70")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113F4E8", Offset = "0x113F4E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600595D")]
			[Address(RVA = "0x1ED4A78", Offset = "0x1ED4A78", VA = "0x7BBC6D4A78")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113F4F8", Offset = "0x113F4F8")]
			set
			{
			}
		}

		// Token: 0x0600595E RID: 22878 RVA: 0x0001A508 File Offset: 0x00018708
		[Token(Token = "0x600595E")]
		[Address(RVA = "0x1ED4A84", Offset = "0x1ED4A84", VA = "0x7BBC6D4A84")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600595F RID: 22879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600595F")]
		[Address(RVA = "0x1ED4AD4", Offset = "0x1ED4AD4", VA = "0x7BBC6D4AD4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005960 RID: 22880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005960")]
		[Address(RVA = "0x1ED4CD0", Offset = "0x1ED4CD0", VA = "0x7BBC6D4CD0", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06005961 RID: 22881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005961")]
		[Address(RVA = "0x1ED4CD8", Offset = "0x1ED4CD8", VA = "0x7BBC6D4CD8")]
		private void OnProfileClick()
		{
		}

		// Token: 0x06005962 RID: 22882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005962")]
		[Address(RVA = "0x1ED4F10", Offset = "0x1ED4F10", VA = "0x7BBC6D4F10", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06005963 RID: 22883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005963")]
		[Address(RVA = "0x1ED509C", Offset = "0x1ED509C", VA = "0x7BBC6D509C")]
		private void UpdateOnlineStateView()
		{
		}

		// Token: 0x06005964 RID: 22884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005964")]
		[Address(RVA = "0x1ED52D8", Offset = "0x1ED52D8", VA = "0x7BBC6D52D8")]
		public UIChampionshipTeamMemberItemController()
		{
		}

		// Token: 0x04007CE5 RID: 31973
		[Token(Token = "0x4007CE5")]
		[FieldOffset(Offset = "0x0")]
		private static Color OnlineColor;

		// Token: 0x04007CE6 RID: 31974
		[Token(Token = "0x4007CE6")]
		[FieldOffset(Offset = "0x10")]
		private static Color OfflineColor;

		// Token: 0x04007CE7 RID: 31975
		[Token(Token = "0x4007CE7")]
		[FieldOffset(Offset = "0x70")]
		private UIChampionshipTeamMemberItemView m_View;

		// Token: 0x04007CE8 RID: 31976
		[Token(Token = "0x4007CE8")]
		[FieldOffset(Offset = "0x78")]
		private UIBaseProfileInfoController m_BaseProfileUI;

		// Token: 0x04007CE9 RID: 31977
		[Token(Token = "0x4007CE9")]
		[FieldOffset(Offset = "0x80")]
		private TeamMemberWithAccountInfo m_TeamMemberData;

		// Token: 0x04007CEA RID: 31978
		[Token(Token = "0x4007CEA")]
		[FieldOffset(Offset = "0x88")]
		private UIModelChampionship m_ModelChampionship;

		// Token: 0x04007CEB RID: 31979
		[Token(Token = "0x4007CEB")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F7EC", Offset = "0x112F7EC")]
		private bool <ShowPresence>k__BackingField;

		// Token: 0x04007CEC RID: 31980
		[Token(Token = "0x4007CEC")]
		[FieldOffset(Offset = "0x91")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F7FC", Offset = "0x112F7FC")]
		private bool <ShowPopupMenu>k__BackingField;
	}
}
