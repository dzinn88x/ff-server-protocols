using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x0200149E RID: 5278
	[Token(Token = "0x200149E")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED3A4", Offset = "0x10ED3A4")]
	public class UIChampionshipTeamProfileController : UIBaseController
	{
		// Token: 0x0600596C RID: 22892 RVA: 0x0001A538 File Offset: 0x00018738
		[Token(Token = "0x600596C")]
		[Address(RVA = "0x1ED672C", Offset = "0x1ED672C", VA = "0x7BBC6D672C")]
		public static ResourceID UIResource()
		{
			return default(ResourceID);
		}

		// Token: 0x0600596D RID: 22893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600596D")]
		[Address(RVA = "0x1ED677C", Offset = "0x1ED677C", VA = "0x7BBC6D677C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600596E RID: 22894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600596E")]
		[Address(RVA = "0x1ED6B9C", Offset = "0x1ED6B9C", VA = "0x7BBC6D6B9C")]
		protected object GetView()
		{
			return null;
		}

		// Token: 0x0600596F RID: 22895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600596F")]
		public T OpenChild<T>(Transform parent) where T : UIBaseController
		{
			return null;
		}

		// Token: 0x06005970 RID: 22896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005970")]
		[Address(RVA = "0x1ED6BA4", Offset = "0x1ED6BA4", VA = "0x7BBC6D6BA4")]
		public void UpdateTeamMemberView(TeamInfo teamInfo, List<TeamMemberWithAccountInfo> members, bool sortPresence = false)
		{
		}

		// Token: 0x06005971 RID: 22897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005971")]
		[Address(RVA = "0x1ED6CD8", Offset = "0x1ED6CD8", VA = "0x7BBC6D6CD8")]
		public void UpdateRecordView(ulong teamID, List<TeamChampionshipMatchStats> matchStats)
		{
		}

		// Token: 0x06005972 RID: 22898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005972")]
		[Address(RVA = "0x1ED735C", Offset = "0x1ED735C", VA = "0x7BBC6D735C")]
		protected void UpdateContentUI(UIChampionshipTeamProfileController.ContentType contentType)
		{
		}

		// Token: 0x06005973 RID: 22899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005973")]
		[Address(RVA = "0x1ED750C", Offset = "0x1ED750C", VA = "0x7BBC6D750C")]
		public UIChampionshipTeamProfileController()
		{
		}

		// Token: 0x04007CF0 RID: 31984
		[Token(Token = "0x4007CF0")]
		[FieldOffset(Offset = "0x58")]
		private UIChampionshipTeamProfileView m_View;

		// Token: 0x04007CF1 RID: 31985
		[Token(Token = "0x4007CF1")]
		[FieldOffset(Offset = "0x60")]
		protected UIChampionshipTeamProfileController.InfoEasyListFactory m_InfoEasyListFactory;

		// Token: 0x04007CF2 RID: 31986
		[Token(Token = "0x4007CF2")]
		[FieldOffset(Offset = "0x68")]
		protected UIChampionshipTeamProfileController.RecordEasyListFactory m_RecordEasyListFactory;

		// Token: 0x04007CF3 RID: 31987
		[Token(Token = "0x4007CF3")]
		[FieldOffset(Offset = "0x70")]
		protected Dictionary<UIChampionshipTeamProfileController.ContentType, GameObject> m_ContentUIs;

		// Token: 0x04007CF4 RID: 31988
		[Token(Token = "0x4007CF4")]
		[FieldOffset(Offset = "0x78")]
		protected UIChampionshipTeamOverviewController m_TeamOverviewUI;

		// Token: 0x04007CF5 RID: 31989
		[Token(Token = "0x4007CF5")]
		[FieldOffset(Offset = "0x80")]
		public List<TeamChampionshipMatchData> m_MatchData;

		// Token: 0x04007CF6 RID: 31990
		[Token(Token = "0x4007CF6")]
		[FieldOffset(Offset = "0x88")]
		protected uint m_ChampionshipType;

		// Token: 0x0200149F RID: 5279
		[Token(Token = "0x200149F")]
		public enum ContentType
		{
			// Token: 0x04007CF8 RID: 31992
			[Token(Token = "0x4007CF8")]
			Memebers,
			// Token: 0x04007CF9 RID: 31993
			[Token(Token = "0x4007CF9")]
			Record
		}

		// Token: 0x020014A0 RID: 5280
		[Token(Token = "0x20014A0")]
		public class InfoEasyListFactory : IEasyList
		{
			// Token: 0x06005974 RID: 22900 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005974")]
			[Address(RVA = "0x1ED6B3C", Offset = "0x1ED6B3C", VA = "0x7BBC6D6B3C")]
			public InfoEasyListFactory(UIChampionshipTeamProfileController teamProfile)
			{
			}

			// Token: 0x06005975 RID: 22901 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005975")]
			[Address(RVA = "0x1ED76C8", Offset = "0x1ED76C8", VA = "0x7BBC6D76C8", Slot = "5")]
			public void CloseItemController(UIEasyListItemController itemController)
			{
			}

			// Token: 0x06005976 RID: 22902 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005976")]
			[Address(RVA = "0x1ED76F8", Offset = "0x1ED76F8", VA = "0x7BBC6D76F8", Slot = "4")]
			public UIEasyListItemController OpenItemController(Transform parent)
			{
				return null;
			}

			// Token: 0x04007CFA RID: 31994
			[Token(Token = "0x4007CFA")]
			[FieldOffset(Offset = "0x10")]
			private UIChampionshipTeamProfileController teamProfile;

			// Token: 0x04007CFB RID: 31995
			[Token(Token = "0x4007CFB")]
			[FieldOffset(Offset = "0x18")]
			public bool ShowPresence;

			// Token: 0x04007CFC RID: 31996
			[Token(Token = "0x4007CFC")]
			[FieldOffset(Offset = "0x19")]
			public bool ShowPopupMenu;
		}

		// Token: 0x020014A1 RID: 5281
		[Token(Token = "0x20014A1")]
		public class RecordEasyListFactory : IEasyList
		{
			// Token: 0x06005977 RID: 22903 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005977")]
			[Address(RVA = "0x1ED6B70", Offset = "0x1ED6B70", VA = "0x7BBC6D6B70")]
			public RecordEasyListFactory(UIChampionshipTeamProfileController teamProfile)
			{
			}

			// Token: 0x06005978 RID: 22904 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005978")]
			[Address(RVA = "0x1ED77A4", Offset = "0x1ED77A4", VA = "0x7BBC6D77A4", Slot = "5")]
			public void CloseItemController(UIEasyListItemController itemController)
			{
			}

			// Token: 0x06005979 RID: 22905 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005979")]
			[Address(RVA = "0x1ED77D4", Offset = "0x1ED77D4", VA = "0x7BBC6D77D4", Slot = "4")]
			public UIEasyListItemController OpenItemController(Transform parent)
			{
				return null;
			}

			// Token: 0x04007CFD RID: 31997
			[Token(Token = "0x4007CFD")]
			[FieldOffset(Offset = "0x10")]
			private UIChampionshipTeamProfileController teamProfile;
		}

		// Token: 0x020014A2 RID: 5282
		[Token(Token = "0x20014A2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10ED3DC", Offset = "0x10ED3DC")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600597B RID: 22907 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600597B")]
			[Address(RVA = "0x1ED7608", Offset = "0x1ED7608", VA = "0x7BBC6D7608")]
			public <>c()
			{
			}

			// Token: 0x0600597C RID: 22908 RVA: 0x0001A550 File Offset: 0x00018750
			[Token(Token = "0x600597C")]
			[Address(RVA = "0x1ED7610", Offset = "0x1ED7610", VA = "0x7BBC6D7610")]
			internal int <UpdateRecordView>b__15_0(TeamChampionshipMatchData a, TeamChampionshipMatchData b)
			{
				return 0;
			}

			// Token: 0x04007CFE RID: 31998
			[Token(Token = "0x4007CFE")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIChampionshipTeamProfileController.<>c <>9;

			// Token: 0x04007CFF RID: 31999
			[Token(Token = "0x4007CFF")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<TeamChampionshipMatchData> <>9__15_0;
		}
	}
}
