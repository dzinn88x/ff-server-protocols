using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000FAE RID: 4014
	[Token(Token = "0x2000FAE")]
	internal class UDPMessagePool<T> : UPDMessagePoolInterface where T : UDPClientMessageBase, new()
	{
		// Token: 0x06003A7F RID: 14975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A7F")]
		public UDPMessagePool()
		{
		}

		// Token: 0x06003A80 RID: 14976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A80")]
		public T Get()
		{
			return null;
		}

		// Token: 0x06003A81 RID: 14977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A81")]
		public void Put(T v)
		{
		}

		// Token: 0x06003A82 RID: 14978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A82")]
		public void Clear()
		{
		}

		// Token: 0x04004C04 RID: 19460
		[Token(Token = "0x4004C04")]
		[FieldOffset(Offset = "0x0")]
		private Queue<T> m_FreeList;
	}
}
