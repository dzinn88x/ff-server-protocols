using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using proto;
using UMA;
using UnityEngine;

namespace COW
{
	// Token: 0x02001A6C RID: 6764
	[Token(Token = "0x2001A6C")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F8264", Offset = "0x10F8264")]
	internal class UIMatchResultScreenshotController : UIBaseController
	{
		// Token: 0x06008E73 RID: 36467 RVA: 0x00026040 File Offset: 0x00024240
		[Token(Token = "0x6008E73")]
		[Address(RVA = "0x147B0E8", Offset = "0x147B0E8", VA = "0x7BBBC7B0E8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008E74 RID: 36468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E74")]
		[Address(RVA = "0x147B138", Offset = "0x147B138", VA = "0x7BBBC7B138", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008E75 RID: 36469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E75")]
		[Address(RVA = "0x147BAC0", Offset = "0x147BAC0", VA = "0x7BBBC7BAC0", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06008E76 RID: 36470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E76")]
		[Address(RVA = "0x147BAC8", Offset = "0x147BAC8", VA = "0x7BBBC7BAC8")]
		public void MakeScreenshot(UIMatchResultScreenshotController.MatchResultScreenshotData data)
		{
		}

		// Token: 0x06008E77 RID: 36471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008E77")]
		[Address(RVA = "0x147D7CC", Offset = "0x147D7CC", VA = "0x7BBBC7D7CC")]
		private string MakeEndgameDescription(uint rank)
		{
			return null;
		}

		// Token: 0x06008E78 RID: 36472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E78")]
		[Address(RVA = "0x147BE1C", Offset = "0x147BE1C", VA = "0x7BBBC7BE1C")]
		private void UpdatePlayerData()
		{
		}

		// Token: 0x06008E79 RID: 36473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E79")]
		[Address(RVA = "0x147D9B8", Offset = "0x147D9B8", VA = "0x7BBBC7D9B8")]
		private void UpdateHeadshot()
		{
		}

		// Token: 0x06008E7A RID: 36474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E7A")]
		[Address(RVA = "0x147DC68", Offset = "0x147DC68", VA = "0x7BBBC7DC68")]
		private void UpdateHeadshot(uint iid)
		{
		}

		// Token: 0x06008E7B RID: 36475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E7B")]
		[Address(RVA = "0x147DD64", Offset = "0x147DD64", VA = "0x7BBBC7DD64")]
		private void UpdateHeadshot(HeadPicData data)
		{
		}

		// Token: 0x06008E7C RID: 36476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E7C")]
		[Address(RVA = "0x147C430", Offset = "0x147C430", VA = "0x7BBBC7C430")]
		private void UpdateCsSeasonRank()
		{
		}

		// Token: 0x06008E7D RID: 36477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E7D")]
		[Address(RVA = "0x147DE68", Offset = "0x147DE68", VA = "0x7BBBC7DE68")]
		private void UpdateRankInfo(int rank)
		{
		}

		// Token: 0x06008E7E RID: 36478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E7E")]
		[Address(RVA = "0x147C7CC", Offset = "0x147C7CC", VA = "0x7BBBC7C7CC")]
		private void UpdateSeasonRank()
		{
		}

		// Token: 0x06008E7F RID: 36479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E7F")]
		[Address(RVA = "0x147CC64", Offset = "0x147CC64", VA = "0x7BBBC7CC64")]
		private void UpdateHighlightRank()
		{
		}

		// Token: 0x06008E80 RID: 36480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E80")]
		[Address(RVA = "0x147CD94", Offset = "0x147CD94", VA = "0x7BBBC7CD94")]
		private void UpdateDetailData()
		{
		}

		// Token: 0x06008E81 RID: 36481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E81")]
		[Address(RVA = "0x147D1D8", Offset = "0x147D1D8", VA = "0x7BBBC7D1D8")]
		private void UpdateGameInfo()
		{
		}

		// Token: 0x06008E82 RID: 36482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E82")]
		[Address(RVA = "0x147D3D8", Offset = "0x147D3D8", VA = "0x7BBBC7D3D8")]
		private void StartRenderPlayerAvatar()
		{
		}

		// Token: 0x06008E83 RID: 36483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E83")]
		[Address(RVA = "0x147DF64", Offset = "0x147DF64", VA = "0x7BBBC7DF64")]
		private void RerenderAfterUMAChanged(UMAData data)
		{
		}

		// Token: 0x06008E84 RID: 36484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E84")]
		[Address(RVA = "0x147E020", Offset = "0x147E020", VA = "0x7BBBC7E020")]
		private void TakeScreenshot()
		{
		}

		// Token: 0x06008E85 RID: 36485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E85")]
		[Address(RVA = "0x147E184", Offset = "0x147E184", VA = "0x7BBBC7E184")]
		public UIMatchResultScreenshotController()
		{
		}

		// Token: 0x06008E86 RID: 36486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E86")]
		[Address(RVA = "0x147E18C", Offset = "0x147E18C", VA = "0x7BBBC7E18C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11446C4", Offset = "0x11446C4")]
		private void <TakeScreenshot>b__28_0()
		{
		}

		// Token: 0x04009A0F RID: 39439
		[Token(Token = "0x4009A0F")]
		[FieldOffset(Offset = "0x58")]
		private UIMatchResultScreenshotView m_View;

		// Token: 0x04009A10 RID: 39440
		[Token(Token = "0x4009A10")]
		[FieldOffset(Offset = "0x60")]
		private UIMatchResultScreenshotController.MatchResultScreenshotData m_Data;

		// Token: 0x04009A11 RID: 39441
		[Token(Token = "0x4009A11")]
		[FieldOffset(Offset = "0x68")]
		private RenderTexture m_PlayerAvatarRenderTexture;

		// Token: 0x04009A12 RID: 39442
		[Token(Token = "0x4009A12")]
		[FieldOffset(Offset = "0x70")]
		private RenderTexture m_ScreenShotRenderTexture;

		// Token: 0x04009A13 RID: 39443
		[Token(Token = "0x4009A13")]
		[FieldOffset(Offset = "0x78")]
		private AvatarManager m_AvatarManager;

		// Token: 0x04009A14 RID: 39444
		[Token(Token = "0x4009A14")]
		[FieldOffset(Offset = "0x80")]
		private List<GameObject> m_ViewTeammates;

		// Token: 0x04009A15 RID: 39445
		[Token(Token = "0x4009A15")]
		[FieldOffset(Offset = "0x88")]
		private List<UILabel> m_ViewTeammateNames;

		// Token: 0x04009A16 RID: 39446
		[Token(Token = "0x4009A16")]
		[FieldOffset(Offset = "0x90")]
		private List<UILabel> m_ViewTeammateKills;

		// Token: 0x04009A17 RID: 39447
		[Token(Token = "0x4009A17")]
		[FieldOffset(Offset = "0x98")]
		private UIMatchResultShare3D m_Share3D;

		// Token: 0x04009A18 RID: 39448
		[Token(Token = "0x4009A18")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_originalShadowEnabled;

		// Token: 0x02001A6D RID: 6765
		[Token(Token = "0x2001A6D")]
		public class MatchResultScreenshotData
		{
			// Token: 0x06008E87 RID: 36487 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008E87")]
			[Address(RVA = "0x147E85C", Offset = "0x147E85C", VA = "0x7BBBC7E85C")]
			public MatchResultScreenshotData()
			{
			}

			// Token: 0x04009A19 RID: 39449
			[Token(Token = "0x4009A19")]
			[FieldOffset(Offset = "0x10")]
			public string Defeater;

			// Token: 0x04009A1A RID: 39450
			[Token(Token = "0x4009A1A")]
			[FieldOffset(Offset = "0x18")]
			public string WeaponDefeatedWith;

			// Token: 0x04009A1B RID: 39451
			[Token(Token = "0x4009A1B")]
			[FieldOffset(Offset = "0x20")]
			public bool DefeaterIsZombie;

			// Token: 0x04009A1C RID: 39452
			[Token(Token = "0x4009A1C")]
			[FieldOffset(Offset = "0x21")]
			public bool IsShowCsRanking;

			// Token: 0x04009A1D RID: 39453
			[Token(Token = "0x4009A1D")]
			[FieldOffset(Offset = "0x24")]
			public uint CsRank;

			// Token: 0x04009A1E RID: 39454
			[Token(Token = "0x4009A1E")]
			[FieldOffset(Offset = "0x28")]
			public uint CsRankPoint;

			// Token: 0x04009A1F RID: 39455
			[Token(Token = "0x4009A1F")]
			[FieldOffset(Offset = "0x2C")]
			public uint Kills;

			// Token: 0x04009A20 RID: 39456
			[Token(Token = "0x4009A20")]
			[FieldOffset(Offset = "0x30")]
			public uint Damages;

			// Token: 0x04009A21 RID: 39457
			[Token(Token = "0x4009A21")]
			[FieldOffset(Offset = "0x34")]
			public uint SurvivedTime_s;

			// Token: 0x04009A22 RID: 39458
			[Token(Token = "0x4009A22")]
			[FieldOffset(Offset = "0x38")]
			public uint Rank;

			// Token: 0x04009A23 RID: 39459
			[Token(Token = "0x4009A23")]
			[FieldOffset(Offset = "0x3C")]
			public uint TotalPlayersCount;

			// Token: 0x04009A24 RID: 39460
			[Token(Token = "0x4009A24")]
			[FieldOffset(Offset = "0x40")]
			public UIMatchResultScreenshotController.MatchResultScreenshotData.TeammateData[] Teammates;

			// Token: 0x04009A25 RID: 39461
			[Token(Token = "0x4009A25")]
			[FieldOffset(Offset = "0x48")]
			public uint MatchMode;

			// Token: 0x04009A26 RID: 39462
			[Token(Token = "0x4009A26")]
			[FieldOffset(Offset = "0x4C")]
			public uint GameMode;

			// Token: 0x04009A27 RID: 39463
			[Token(Token = "0x4009A27")]
			[FieldOffset(Offset = "0x50")]
			public uint MapID;

			// Token: 0x04009A28 RID: 39464
			[Token(Token = "0x4009A28")]
			[FieldOffset(Offset = "0x58")]
			public MatchStats MatchStats;

			// Token: 0x02001A6E RID: 6766
			[Token(Token = "0x2001A6E")]
			public class TeammateData
			{
				// Token: 0x06008E88 RID: 36488 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008E88")]
				[Address(RVA = "0x147E790", Offset = "0x147E790", VA = "0x7BBBC7E790")]
				public TeammateData()
				{
				}

				// Token: 0x04009A29 RID: 39465
				[Token(Token = "0x4009A29")]
				[FieldOffset(Offset = "0x10")]
				public string Nickname;

				// Token: 0x04009A2A RID: 39466
				[Token(Token = "0x4009A2A")]
				[FieldOffset(Offset = "0x18")]
				public uint Kills;
			}
		}

		// Token: 0x02001A6F RID: 6767
		[Token(Token = "0x2001A6F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F829C", Offset = "0x10F829C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06008E8A RID: 36490 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008E8A")]
			[Address(RVA = "0x147E6E0", Offset = "0x147E6E0", VA = "0x7BBBC7E6E0")]
			public <>c()
			{
			}

			// Token: 0x06008E8B RID: 36491 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6008E8B")]
			[Address(RVA = "0x147E6E8", Offset = "0x147E6E8", VA = "0x7BBBC7E6E8")]
			internal UIMatchResultScreenshotController.MatchResultScreenshotData.TeammateData <MakeScreenshot>b__14_0(TeammateStats datum)
			{
				return null;
			}

			// Token: 0x06008E8C RID: 36492 RVA: 0x00026058 File Offset: 0x00024258
			[Token(Token = "0x6008E8C")]
			[Address(RVA = "0x147E798", Offset = "0x147E798", VA = "0x7BBBC7E798")]
			internal bool <MakeScreenshot>b__14_1(UIMatchResultScreenshotController.MatchResultScreenshotData.TeammateData val)
			{
				return default(bool);
			}

			// Token: 0x04009A2B RID: 39467
			[Token(Token = "0x4009A2B")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIMatchResultScreenshotController.<>c <>9;

			// Token: 0x04009A2C RID: 39468
			[Token(Token = "0x4009A2C")]
			[FieldOffset(Offset = "0x8")]
			public static Converter<TeammateStats, UIMatchResultScreenshotController.MatchResultScreenshotData.TeammateData> <>9__14_0;

			// Token: 0x04009A2D RID: 39469
			[Token(Token = "0x4009A2D")]
			[FieldOffset(Offset = "0x10")]
			public static Func<UIMatchResultScreenshotController.MatchResultScreenshotData.TeammateData, bool> <>9__14_1;
		}
	}
}
