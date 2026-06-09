using System;
using Il2CppDummyDll;

namespace COW.GamePlay
{
	// Token: 0x0200283A RID: 10298
	[Token(Token = "0x200283A")]
	public class LevelClimbingTrigger : BaseLevelObject
	{
		// Token: 0x0600D8EC RID: 55532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D8EC")]
		[Address(RVA = "0x15885E4", Offset = "0x15885E4", VA = "0x7BBBD885E4", Slot = "32")]
		protected override string GetObjectTag()
		{
			return null;
		}

		// Token: 0x0600D8ED RID: 55533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D8ED")]
		[Address(RVA = "0x158862C", Offset = "0x158862C", VA = "0x7BBBD8862C", Slot = "27")]
		public override void SyncAction(params object[] OSvO{nh)
		{
		}

		// Token: 0x0600D8EE RID: 55534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D8EE")]
		[Address(RVA = "0x1588634", Offset = "0x1588634", VA = "0x7BBBD88634")]
		public LevelClimbingTrigger()
		{
		}

		// Token: 0x0401092D RID: 67885
		[Token(Token = "0x401092D")]
		[FieldOffset(Offset = "0x68")]
		public ClimbingTrigger Trigger;
	}
}
