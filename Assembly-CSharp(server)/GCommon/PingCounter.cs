using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000F3B RID: 3899
	[Token(Token = "0x2000F3B")]
	public class PingCounter : MonoBehaviour
	{
		// Token: 0x060037E9 RID: 14313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037E9")]
		[Address(RVA = "0x246D618", Offset = "0x246D618", VA = "0x7BBCC6D618")]
		private void Awake()
		{
		}

		// Token: 0x060037EA RID: 14314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037EA")]
		[Address(RVA = "0x246D6B8", Offset = "0x246D6B8", VA = "0x7BBCC6D6B8")]
		public void PingSent(int sendCount)
		{
		}

		// Token: 0x060037EB RID: 14315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037EB")]
		[Address(RVA = "0x246D998", Offset = "0x246D998", VA = "0x7BBCC6D998")]
		public void PushPingPack(int sendCount)
		{
		}

		// Token: 0x060037EC RID: 14316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037EC")]
		[Address(RVA = "0x246D748", Offset = "0x246D748", VA = "0x7BBCC6D748")]
		public void PushPingValue(int value)
		{
		}

		// Token: 0x060037ED RID: 14317 RVA: 0x000114D8 File Offset: 0x0000F6D8
		[Token(Token = "0x60037ED")]
		[Address(RVA = "0x246DAC8", Offset = "0x246DAC8", VA = "0x7BBCC6DAC8")]
		public int CurrentPingValue()
		{
			return 0;
		}

		// Token: 0x060037EE RID: 14318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037EE")]
		[Address(RVA = "0x246DB14", Offset = "0x246DB14", VA = "0x7BBCC6DB14")]
		public void StartCountToServer()
		{
		}

		// Token: 0x060037EF RID: 14319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037EF")]
		[Address(RVA = "0x246DB20", Offset = "0x246DB20", VA = "0x7BBCC6DB20")]
		public void PopPingToServer(out int average, out int max, out int avgB500, out int count100200, out int count200300, out int count300400, out int count400500, out int countA500, out int total)
		{
		}

		// Token: 0x060037F0 RID: 14320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037F0")]
		[Address(RVA = "0x246DBA0", Offset = "0x246DBA0", VA = "0x7BBCC6DBA0")]
		public void Clear()
		{
		}

		// Token: 0x060037F1 RID: 14321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037F1")]
		[Address(RVA = "0x246DC1C", Offset = "0x246DC1C", VA = "0x7BBCC6DC1C")]
		public PingCounter()
		{
		}

		// Token: 0x04004A45 RID: 19013
		[Token(Token = "0x4004A45")]
		[FieldOffset(Offset = "0x0")]
		public static PingCounter instance;

		// Token: 0x04004A46 RID: 19014
		[Token(Token = "0x4004A46")]
		[FieldOffset(Offset = "0x18")]
		private Queue<int> m_PingQueue;

		// Token: 0x04004A47 RID: 19015
		[Token(Token = "0x4004A47")]
		[FieldOffset(Offset = "0x20")]
		private int m_TotalPingValue;

		// Token: 0x04004A48 RID: 19016
		[Token(Token = "0x4004A48")]
		[FieldOffset(Offset = "0x24")]
		private int m_CurPingValue;

		// Token: 0x04004A49 RID: 19017
		[Token(Token = "0x4004A49")]
		[FieldOffset(Offset = "0x28")]
		private int m_TotalServerPingLag;

		// Token: 0x04004A4A RID: 19018
		[Token(Token = "0x4004A4A")]
		[FieldOffset(Offset = "0x2C")]
		private int m_TotalServerPingCount;

		// Token: 0x04004A4B RID: 19019
		[Token(Token = "0x4004A4B")]
		[FieldOffset(Offset = "0x30")]
		private int m_TotalServerPingLagB500;

		// Token: 0x04004A4C RID: 19020
		[Token(Token = "0x4004A4C")]
		[FieldOffset(Offset = "0x34")]
		private int m_TotalServerPingCountB500;

		// Token: 0x04004A4D RID: 19021
		[Token(Token = "0x4004A4D")]
		[FieldOffset(Offset = "0x38")]
		private int m_TotalServerPingLag100_200;

		// Token: 0x04004A4E RID: 19022
		[Token(Token = "0x4004A4E")]
		[FieldOffset(Offset = "0x3C")]
		private int m_TotalServerPingCount100_200;

		// Token: 0x04004A4F RID: 19023
		[Token(Token = "0x4004A4F")]
		[FieldOffset(Offset = "0x40")]
		private int m_TotalServerPingLag200_300;

		// Token: 0x04004A50 RID: 19024
		[Token(Token = "0x4004A50")]
		[FieldOffset(Offset = "0x44")]
		private int m_TotalServerPingCount200_300;

		// Token: 0x04004A51 RID: 19025
		[Token(Token = "0x4004A51")]
		[FieldOffset(Offset = "0x48")]
		private int m_TotalServerPingLag300_400;

		// Token: 0x04004A52 RID: 19026
		[Token(Token = "0x4004A52")]
		[FieldOffset(Offset = "0x4C")]
		private int m_TotalServerPingCount300_400;

		// Token: 0x04004A53 RID: 19027
		[Token(Token = "0x4004A53")]
		[FieldOffset(Offset = "0x50")]
		private int m_TotalServerPingLag400_500;

		// Token: 0x04004A54 RID: 19028
		[Token(Token = "0x4004A54")]
		[FieldOffset(Offset = "0x54")]
		private int m_TotalServerPingCount400_500;

		// Token: 0x04004A55 RID: 19029
		[Token(Token = "0x4004A55")]
		[FieldOffset(Offset = "0x58")]
		private int m_TotalServerPingLagA500;

		// Token: 0x04004A56 RID: 19030
		[Token(Token = "0x4004A56")]
		[FieldOffset(Offset = "0x5C")]
		private int m_TotalServerPingCountA500;

		// Token: 0x04004A57 RID: 19031
		[Token(Token = "0x4004A57")]
		[FieldOffset(Offset = "0x60")]
		private int m_MaxServerPing;

		// Token: 0x04004A58 RID: 19032
		[Token(Token = "0x4004A58")]
		[FieldOffset(Offset = "0x64")]
		private bool m_StartToCollectPing;

		// Token: 0x04004A59 RID: 19033
		[Token(Token = "0x4004A59")]
		[FieldOffset(Offset = "0x68")]
		private float m_StartShowTime;

		// Token: 0x04004A5A RID: 19034
		[Token(Token = "0x4004A5A")]
		[FieldOffset(Offset = "0x6C")]
		private int m_LastSendPingCount;

		// Token: 0x04004A5B RID: 19035
		[Token(Token = "0x4004A5B")]
		[FieldOffset(Offset = "0x70")]
		private bool m_LastPingBack;

		// Token: 0x04004A5C RID: 19036
		[Token(Token = "0x4004A5C")]
		[FieldOffset(Offset = "0x8")]
		public static int PING_COUNT;

		// Token: 0x04004A5D RID: 19037
		[Token(Token = "0x4004A5D")]
		[FieldOffset(Offset = "0xC")]
		public static int PING_MAXVALUE;
	}
}
