using System;
using Il2CppDummyDll;

namespace COW.GamePlay
{
	// Token: 0x02002857 RID: 10327
	[Token(Token = "0x2002857")]
	public class LevelFeedZone : BaseLevelObject
	{
		// Token: 0x0600D9CF RID: 55759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9CF")]
		[Address(RVA = "0x1EAE16C", Offset = "0x1EAE16C", VA = "0x7BBC6AE16C")]
		public void OnLocalPlayerEnterTrigger()
		{
		}

		// Token: 0x0600D9D0 RID: 55760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9D0")]
		[Address(RVA = "0x1EAE410", Offset = "0x1EAE410", VA = "0x7BBC6AE410")]
		public void OnLocalPlayerExitTrigger()
		{
		}

		// Token: 0x0600D9D1 RID: 55761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D9D1")]
		[Address(RVA = "0x1EAE59C", Offset = "0x1EAE59C", VA = "0x7BBC6AE59C", Slot = "32")]
		protected override string GetObjectTag()
		{
			return null;
		}

		// Token: 0x0600D9D2 RID: 55762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9D2")]
		[Address(RVA = "0x1EAE5E4", Offset = "0x1EAE5E4", VA = "0x7BBC6AE5E4")]
		public LevelFeedZone()
		{
		}

		// Token: 0x040109DA RID: 68058
		[Token(Token = "0x40109DA")]
		[FieldOffset(Offset = "0x68")]
		public uint teammodeid;

		// Token: 0x040109DB RID: 68059
		[Token(Token = "0x40109DB")]
		[FieldOffset(Offset = "0x6C")]
		public int milestoneid;
	}
}
