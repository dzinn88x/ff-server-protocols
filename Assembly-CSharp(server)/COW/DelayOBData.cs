using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020012B2 RID: 4786
	[Token(Token = "0x20012B2")]
	internal class DelayOBData : ObjectPoolCallbackBase
	{
		// Token: 0x06004AFB RID: 19195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AFB")]
		[Address(RVA = "0x1600EEC", Offset = "0x1600EEC", VA = "0x7BBBE00EEC")]
		public static DelayOBData Get()
		{
			return null;
		}

		// Token: 0x06004AFC RID: 19196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AFC")]
		[Address(RVA = "0x1600F70", Offset = "0x1600F70", VA = "0x7BBBE00F70")]
		public static void Put(DelayOBData p)
		{
		}

		// Token: 0x06004AFD RID: 19197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AFD")]
		[Address(RVA = "0x1600FFC", Offset = "0x1600FFC", VA = "0x7BBBE00FFC")]
		public static void ClearCache()
		{
		}

		// Token: 0x06004AFE RID: 19198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AFE")]
		[Address(RVA = "0x160107C", Offset = "0x160107C", VA = "0x7BBBE0107C", Slot = "7")]
		public override void OnAllocated()
		{
		}

		// Token: 0x06004AFF RID: 19199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AFF")]
		[Address(RVA = "0x16010E8", Offset = "0x16010E8", VA = "0x7BBBE010E8")]
		public void SetTime(float time)
		{
		}

		// Token: 0x06004B00 RID: 19200 RVA: 0x000168A8 File Offset: 0x00014AA8
		[Token(Token = "0x6004B00")]
		[Address(RVA = "0x16010F0", Offset = "0x16010F0", VA = "0x7BBBE010F0")]
		public float GetTime()
		{
			return 0f;
		}

		// Token: 0x06004B01 RID: 19201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B01")]
		[Address(RVA = "0x16010F8", Offset = "0x16010F8", VA = "0x7BBBE010F8")]
		public Queue<UDPMsgPacket> GetPacketsQueue()
		{
			return null;
		}

		// Token: 0x06004B02 RID: 19202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B02")]
		[Address(RVA = "0x1601100", Offset = "0x1601100", VA = "0x7BBBE01100")]
		public DelayOBData()
		{
		}

		// Token: 0x04007328 RID: 29480
		[Token(Token = "0x4007328")]
		[FieldOffset(Offset = "0x0")]
		private static ObjectPool<DelayOBData> m_DelayOBPacketsPool;

		// Token: 0x04007329 RID: 29481
		[Token(Token = "0x4007329")]
		[FieldOffset(Offset = "0x18")]
		private Queue<UDPMsgPacket> m_Packets;

		// Token: 0x0400732A RID: 29482
		[Token(Token = "0x400732A")]
		[FieldOffset(Offset = "0x20")]
		private float m_Time;
	}
}
