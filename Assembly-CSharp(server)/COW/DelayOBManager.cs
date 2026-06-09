using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020012B3 RID: 4787
	[Token(Token = "0x20012B3")]
	internal class DelayOBManager : SingletonModule<DelayOBManager>
	{
		// Token: 0x06004B04 RID: 19204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B04")]
		[Address(RVA = "0x16011E4", Offset = "0x16011E4", VA = "0x7BBBE011E4", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x06004B05 RID: 19205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B05")]
		[Address(RVA = "0x160124C", Offset = "0x160124C", VA = "0x7BBBE0124C", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x06004B06 RID: 19206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B06")]
		[Address(RVA = "0x16012D0", Offset = "0x16012D0", VA = "0x7BBBE012D0")]
		public void OnStarted()
		{
		}

		// Token: 0x06004B07 RID: 19207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B07")]
		[Address(RVA = "0x16015A4", Offset = "0x16015A4", VA = "0x7BBBE015A4")]
		public void OnEnded()
		{
		}

		// Token: 0x06004B08 RID: 19208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B08")]
		[Address(RVA = "0x16015AC", Offset = "0x16015AC", VA = "0x7BBBE015AC")]
		public DelayOBData CachedDelayedPackets(DelayOBData data)
		{
			return null;
		}

		// Token: 0x06004B09 RID: 19209 RVA: 0x000168C0 File Offset: 0x00014AC0
		[Token(Token = "0x6004B09")]
		[Address(RVA = "0x16016B8", Offset = "0x16016B8", VA = "0x7BBBE016B8")]
		public bool IsUDPTimeoutIngored()
		{
			return default(bool);
		}

		// Token: 0x06004B0A RID: 19210 RVA: 0x000168D8 File Offset: 0x00014AD8
		[Token(Token = "0x6004B0A")]
		[Address(RVA = "0x16016D8", Offset = "0x16016D8", VA = "0x7BBBE016D8")]
		public bool IsDelayOBState()
		{
			return default(bool);
		}

		// Token: 0x06004B0B RID: 19211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B0B")]
		[Address(RVA = "0x1601754", Offset = "0x1601754", VA = "0x7BBBE01754")]
		public DelayOBManager()
		{
		}

		// Token: 0x0400732B RID: 29483
		[Token(Token = "0x400732B")]
		[FieldOffset(Offset = "0x12")]
		private bool m_DelayOBEnabled;

		// Token: 0x0400732C RID: 29484
		[Token(Token = "0x400732C")]
		[FieldOffset(Offset = "0x14")]
		private float m_DelayOBSeconds;

		// Token: 0x0400732D RID: 29485
		[Token(Token = "0x400732D")]
		[FieldOffset(Offset = "0x18")]
		private float m_CurTimeSecond;

		// Token: 0x0400732E RID: 29486
		[Token(Token = "0x400732E")]
		[FieldOffset(Offset = "0x1C")]
		private bool m_Started;

		// Token: 0x0400732F RID: 29487
		[Token(Token = "0x400732F")]
		[FieldOffset(Offset = "0x20")]
		private Queue<DelayOBData> m_DelayOBPacketsQueue;
	}
}
