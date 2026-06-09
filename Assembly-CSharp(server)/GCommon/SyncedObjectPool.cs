using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000ECD RID: 3789
	[Token(Token = "0x2000ECD")]
	public class SyncedObjectPool<T> : ObjectPool<!0> where T : IObjectPoolCallback, new()
	{
		// Token: 0x06003442 RID: 13378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003442")]
		protected override IObjectPoolCallback AllocObjectInternal()
		{
			return null;
		}

		// Token: 0x06003443 RID: 13379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003443")]
		protected override void CollectObjectInternal(T obj)
		{
		}

		// Token: 0x06003444 RID: 13380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003444")]
		public override void Clear()
		{
		}

		// Token: 0x06003445 RID: 13381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003445")]
		public SyncedObjectPool()
		{
		}
	}
}
