using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x02002832 RID: 10290
	[Token(Token = "0x2002832")]
	internal class LevelBountyTeleportMachine : BaseLevelObject
	{
		// Token: 0x0600D8A9 RID: 55465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D8A9")]
		[Address(RVA = "0x158201C", Offset = "0x158201C", VA = "0x7BBBD8201C", Slot = "32")]
		protected override string GetObjectTag()
		{
			return null;
		}

		// Token: 0x0600D8AA RID: 55466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D8AA")]
		[Address(RVA = "0x1582064", Offset = "0x1582064", VA = "0x7BBBD82064", Slot = "12")]
		protected override void OnStart()
		{
		}

		// Token: 0x0600D8AB RID: 55467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D8AB")]
		[Address(RVA = "0x1582104", Offset = "0x1582104", VA = "0x7BBBD82104", Slot = "20")]
		protected override void OnUserDefineReplicationInfo()
		{
		}

		// Token: 0x0600D8AC RID: 55468 RVA: 0x0003BD78 File Offset: 0x00039F78
		[Token(Token = "0x600D8AC")]
		[Address(RVA = "0x158220C", Offset = "0x158220C", VA = "0x7BBBD8220C", Slot = "22")]
		protected override int GetMaxRepDataCount()
		{
			return 0;
		}

		// Token: 0x0600D8AD RID: 55469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D8AD")]
		[Address(RVA = "0x1582214", Offset = "0x1582214", VA = "0x7BBBD82214")]
		private void zyfWDnr(uint l]jgxbG, uint TzzPYjI)
		{
		}

		// Token: 0x0600D8AE RID: 55470 RVA: 0x0003BD90 File Offset: 0x00039F90
		[Token(Token = "0x600D8AE")]
		[Address(RVA = "0x1582478", Offset = "0x1582478", VA = "0x7BBBD82478")]
		public uint GetCurState()
		{
			return 0U;
		}

		// Token: 0x0600D8AF RID: 55471 RVA: 0x0003BDA8 File Offset: 0x00039FA8
		[Token(Token = "0x600D8AF")]
		[Address(RVA = "0x15824DC", Offset = "0x15824DC", VA = "0x7BBBD824DC")]
		public bool CanUse()
		{
			return default(bool);
		}

		// Token: 0x0600D8B0 RID: 55472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D8B0")]
		[Address(RVA = "0x1582540", Offset = "0x1582540", VA = "0x7BBBD82540", Slot = "26")]
		public override void DoAction(params object[] OSvO{nh)
		{
		}

		// Token: 0x0600D8B1 RID: 55473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D8B1")]
		[Address(RVA = "0x15829C4", Offset = "0x15829C4", VA = "0x7BBBD829C4")]
		private void ^tntjeQ()
		{
		}

		// Token: 0x0600D8B2 RID: 55474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D8B2")]
		[Address(RVA = "0x1582A50", Offset = "0x1582A50", VA = "0x7BBBD82A50", Slot = "34")]
		public override void TakeHealing(int wE~rpy\u0082, {QAb\u0082~u a\u0082uxIoj, int dwdYABP, [Optional] Vector3 `oVk\u0080^H, [Optional] Vector3 ft|sF}F, [Optional] List<float> `KEFVvE)
		{
		}

		// Token: 0x0600D8B3 RID: 55475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D8B3")]
		[Address(RVA = "0x1583058", Offset = "0x1583058", VA = "0x7BBBD83058")]
		public LevelBountyTeleportMachine()
		{
		}

		// Token: 0x040108F7 RID: 67831
		[Token(Token = "0x40108F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public GameObject BrokenRoot;

		// Token: 0x040108F8 RID: 67832
		[Token(Token = "0x40108F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public GameObject RepairingRoot;

		// Token: 0x040108F9 RID: 67833
		[Token(Token = "0x40108F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public GameObject EnableRoot;

		// Token: 0x040108FA RID: 67834
		[Token(Token = "0x40108FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public BoxCollider Trigger;
	}
}
