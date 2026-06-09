using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000ECC RID: 3788
	[Token(Token = "0x2000ECC")]
	public class ObjectPool<T> where T : IObjectPoolCallback, new()
	{
		// Token: 0x0600343C RID: 13372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600343C")]
		public ObjectPool()
		{
		}

		// Token: 0x0600343D RID: 13373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600343D")]
		public T AllocObject()
		{
			return null;
		}

		// Token: 0x0600343E RID: 13374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600343E")]
		public void CollectObject(T obj)
		{
		}

		// Token: 0x0600343F RID: 13375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600343F")]
		public virtual void Clear()
		{
		}

		// Token: 0x06003440 RID: 13376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003440")]
		protected virtual IObjectPoolCallback AllocObjectInternal()
		{
			return null;
		}

		// Token: 0x06003441 RID: 13377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003441")]
		protected virtual void CollectObjectInternal(T obj)
		{
		}

		// Token: 0x04004804 RID: 18436
		[Token(Token = "0x4004804")]
		[FieldOffset(Offset = "0x0")]
		protected Queue<T> m_FreeObjects;
	}
}
