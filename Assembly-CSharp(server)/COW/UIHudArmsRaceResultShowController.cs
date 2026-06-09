using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001427 RID: 5159
	[Token(Token = "0x2001427")]
	internal class UIHudArmsRaceResultShowController : UIHudResultShowBaseController
	{
		// Token: 0x0600553E RID: 21822 RVA: 0x000196B0 File Offset: 0x000178B0
		[Token(Token = "0x600553E")]
		[Address(RVA = "0x1886D94", Offset = "0x1886D94", VA = "0x7BBC086D94")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600553F RID: 21823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600553F")]
		[Address(RVA = "0x1886DE4", Offset = "0x1886DE4", VA = "0x7BBC086DE4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005540 RID: 21824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005540")]
		[Address(RVA = "0x1886EE0", Offset = "0x1886EE0", VA = "0x7BBC086EE0")]
		private void InitRankObj()
		{
		}

		// Token: 0x06005541 RID: 21825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005541")]
		[Address(RVA = "0x1886FEC", Offset = "0x1886FEC", VA = "0x7BBC086FEC", Slot = "30")]
		protected override void OnMatchStatsChange(MatchStats stats, MatchIncome income)
		{
		}

		// Token: 0x06005542 RID: 21826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005542")]
		[Address(RVA = "0x18870B8", Offset = "0x18870B8", VA = "0x7BBC0870B8", Slot = "39")]
		protected override void InitResultShowWindow()
		{
		}

		// Token: 0x06005543 RID: 21827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005543")]
		[Address(RVA = "0x1887120", Offset = "0x1887120", VA = "0x7BBC087120", Slot = "38")]
		protected override List<PlayerData> CreateResultData()
		{
			return null;
		}

		// Token: 0x06005544 RID: 21828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005544")]
		[Address(RVA = "0x188734C", Offset = "0x188734C", VA = "0x7BBC08734C", Slot = "36")]
		public override void CreateProfileCallSign(PlayerData data, int index)
		{
		}

		// Token: 0x06005545 RID: 21829 RVA: 0x000196C8 File Offset: 0x000178C8
		[Token(Token = "0x6005545")]
		[Address(RVA = "0x1887508", Offset = "0x1887508", VA = "0x7BBC087508", Slot = "33")]
		protected override bool HasDefeater(MatchStats stats)
		{
			return default(bool);
		}

		// Token: 0x06005546 RID: 21830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005546")]
		[Address(RVA = "0x1887510", Offset = "0x1887510", VA = "0x7BBC087510", Slot = "34")]
		protected override void ReturnToLobby()
		{
		}

		// Token: 0x06005547 RID: 21831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005547")]
		[Address(RVA = "0x18875E0", Offset = "0x18875E0", VA = "0x7BBC0875E0")]
		public UIHudArmsRaceResultShowController()
		{
		}

		// Token: 0x04007A44 RID: 31300
		[Token(Token = "0x4007A44")]
		[FieldOffset(Offset = "0xD8")]
		private UIHudArmsRaceResultShowView m_View;

		// Token: 0x04007A45 RID: 31301
		[Token(Token = "0x4007A45")]
		[FieldOffset(Offset = "0xE0")]
		private List<GameObject> m_RankObj;

		// Token: 0x04007A46 RID: 31302
		[Token(Token = "0x4007A46")]
		[FieldOffset(Offset = "0xE8")]
		private Vector3 m_FirstRankPos;

		// Token: 0x04007A47 RID: 31303
		[Token(Token = "0x4007A47")]
		[FieldOffset(Offset = "0xF4")]
		private Vector3 m_OtherRankPos;
	}
}
