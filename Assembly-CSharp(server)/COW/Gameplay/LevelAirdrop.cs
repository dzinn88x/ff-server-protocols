using System;
using Il2CppDummyDll;

namespace COW.GamePlay
{
	// Token: 0x02002826 RID: 10278
	[Token(Token = "0x2002826")]
	internal class LevelAirdrop : BaseLevelObject
	{
		// Token: 0x0600D85F RID: 55391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D85F")]
		[Address(RVA = "0x157C040", Offset = "0x157C040", VA = "0x7BBBD7C040", Slot = "32")]
		protected override string GetObjectTag()
		{
			return null;
		}

		// Token: 0x0600D860 RID: 55392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D860")]
		[Address(RVA = "0x157C088", Offset = "0x157C088", VA = "0x7BBBD7C088")]
		public void SetShowOnMap(bool \u0081OTRX|})
		{
		}

		// Token: 0x0600D861 RID: 55393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D861")]
		[Address(RVA = "0x157C098", Offset = "0x157C098", VA = "0x7BBBD7C098", Slot = "15")]
		public override void OnUpdate(float \u0081}x[tOF, float OsUltaA)
		{
		}

		// Token: 0x0600D862 RID: 55394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D862")]
		[Address(RVA = "0x157C3AC", Offset = "0x157C3AC", VA = "0x7BBBD7C3AC", Slot = "13")]
		protected override void OnOnDestroy()
		{
		}

		// Token: 0x0600D863 RID: 55395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D863")]
		[Address(RVA = "0x157C17C", Offset = "0x157C17C", VA = "0x7BBBD7C17C")]
		private void \u007FNjsUMo(bool \u0081OTRX|})
		{
		}

		// Token: 0x0600D864 RID: 55396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D864")]
		[Address(RVA = "0x157C3EC", Offset = "0x157C3EC", VA = "0x7BBBD7C3EC", Slot = "27")]
		public override void SyncAction(params object[] OSvO{nh)
		{
		}

		// Token: 0x0600D865 RID: 55397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D865")]
		[Address(RVA = "0x157C738", Offset = "0x157C738", VA = "0x7BBBD7C738")]
		public LevelAirdrop()
		{
		}

		// Token: 0x040108BD RID: 67773
		[Token(Token = "0x40108BD")]
		[FieldOffset(Offset = "0x68")]
		public Airdrop m_Airdrop;

		// Token: 0x040108BE RID: 67774
		[Token(Token = "0x40108BE")]
		[FieldOffset(Offset = "0x70")]
		private bool K\u0081jIGNI;

		// Token: 0x040108BF RID: 67775
		[Token(Token = "0x40108BF")]
		[FieldOffset(Offset = "0x71")]
		private bool wtSDYP\u0082;

		// Token: 0x02002827 RID: 10279
		[Token(Token = "0x2002827")]
		public enum ]R\u007F{I^
		{
			// Token: 0x040108C1 RID: 67777
			[Token(Token = "0x40108C1")]
			SYNC_STATE,
			// Token: 0x040108C2 RID: 67778
			[Token(Token = "0x40108C2")]
			INTO_WATER,
			// Token: 0x040108C3 RID: 67779
			[Token(Token = "0x40108C3")]
			SYNC_REENTER,
			// Token: 0x040108C4 RID: 67780
			[Token(Token = "0x40108C4")]
			SYNC_ZombieSurprise,
			// Token: 0x040108C5 RID: 67781
			[Token(Token = "0x40108C5")]
			DESTROY
		}
	}
}
