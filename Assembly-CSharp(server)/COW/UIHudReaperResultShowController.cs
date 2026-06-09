using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x0200164A RID: 5706
	[Token(Token = "0x200164A")]
	internal class UIHudReaperResultShowController : UIHudResultShowBaseController
	{
		// Token: 0x060066F8 RID: 26360 RVA: 0x0001D5F8 File Offset: 0x0001B7F8
		[Token(Token = "0x60066F8")]
		[Address(RVA = "0x17EC0AC", Offset = "0x17EC0AC", VA = "0x7BBBFEC0AC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060066F9 RID: 26361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066F9")]
		[Address(RVA = "0x17EC0FC", Offset = "0x17EC0FC", VA = "0x7BBBFEC0FC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060066FA RID: 26362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066FA")]
		[Address(RVA = "0x17EC1F8", Offset = "0x17EC1F8", VA = "0x7BBBFEC1F8")]
		private void InitRankObj()
		{
		}

		// Token: 0x060066FB RID: 26363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066FB")]
		[Address(RVA = "0x17EC304", Offset = "0x17EC304", VA = "0x7BBBFEC304", Slot = "30")]
		protected override void OnMatchStatsChange(MatchStats stats, MatchIncome income)
		{
		}

		// Token: 0x060066FC RID: 26364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066FC")]
		[Address(RVA = "0x17EC5F4", Offset = "0x17EC5F4", VA = "0x7BBBFEC5F4", Slot = "39")]
		protected override void InitResultShowWindow()
		{
		}

		// Token: 0x060066FD RID: 26365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066FD")]
		[Address(RVA = "0x17EC65C", Offset = "0x17EC65C", VA = "0x7BBBFEC65C", Slot = "38")]
		protected override List<PlayerData> CreateResultData()
		{
			return null;
		}

		// Token: 0x060066FE RID: 26366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066FE")]
		[Address(RVA = "0x17EC94C", Offset = "0x17EC94C", VA = "0x7BBBFEC94C", Slot = "36")]
		public override void CreateProfileCallSign(PlayerData data, int index)
		{
		}

		// Token: 0x060066FF RID: 26367 RVA: 0x0001D610 File Offset: 0x0001B810
		[Token(Token = "0x60066FF")]
		[Address(RVA = "0x17ECDDC", Offset = "0x17ECDDC", VA = "0x7BBBFECDDC", Slot = "33")]
		protected override bool HasDefeater(MatchStats stats)
		{
			return default(bool);
		}

		// Token: 0x06006700 RID: 26368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006700")]
		[Address(RVA = "0x17ECDE4", Offset = "0x17ECDE4", VA = "0x7BBBFECDE4", Slot = "34")]
		protected override void ReturnToLobby()
		{
		}

		// Token: 0x06006701 RID: 26369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006701")]
		[Address(RVA = "0x17ECEB4", Offset = "0x17ECEB4", VA = "0x7BBBFECEB4")]
		public UIHudReaperResultShowController()
		{
		}

		// Token: 0x0400847F RID: 33919
		[Token(Token = "0x400847F")]
		[FieldOffset(Offset = "0xD8")]
		private UIHudArmsRaceResultShowView m_View;

		// Token: 0x04008480 RID: 33920
		[Token(Token = "0x4008480")]
		[FieldOffset(Offset = "0xE0")]
		private List<GameObject> m_RankObj;

		// Token: 0x04008481 RID: 33921
		[Token(Token = "0x4008481")]
		[FieldOffset(Offset = "0xE8")]
		private Vector3 m_FirstRankPos;

		// Token: 0x04008482 RID: 33922
		[Token(Token = "0x4008482")]
		[FieldOffset(Offset = "0xF4")]
		private Vector3 m_OtherRankPos;

		// Token: 0x0200164B RID: 5707
		[Token(Token = "0x200164B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EFF6C", Offset = "0x10EFF6C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006703 RID: 26371 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006703")]
			[Address(RVA = "0x17ED088", Offset = "0x17ED088", VA = "0x7BBBFED088")]
			public <>c()
			{
			}

			// Token: 0x06006704 RID: 26372 RVA: 0x0001D628 File Offset: 0x0001B828
			[Token(Token = "0x6006704")]
			[Address(RVA = "0x17ED090", Offset = "0x17ED090", VA = "0x7BBBFED090")]
			internal int <CreateResultData>b__9_0(TeammateStats a, TeammateStats b)
			{
				return 0;
			}

			// Token: 0x04008483 RID: 33923
			[Token(Token = "0x4008483")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIHudReaperResultShowController.<>c <>9;

			// Token: 0x04008484 RID: 33924
			[Token(Token = "0x4008484")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<TeammateStats> <>9__9_0;
		}
	}
}
