using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000F9C RID: 3996
	[Token(Token = "0x2000F9C")]
	public class ReplicationDataPool
	{
		// Token: 0x06003A2C RID: 14892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A2C")]
		[Address(RVA = "0x295EF48", Offset = "0x295EF48", VA = "0x7BBD15EF48")]
		public ReplicationDataPool(int maxVarCount)
		{
		}

		// Token: 0x06003A2D RID: 14893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A2D")]
		public void RegisterDataChangedHanlder<T>(uint varID, ReplicationDataPool.DataChangedHanlder<T> handler)
		{
		}

		// Token: 0x06003A2E RID: 14894 RVA: 0x00012018 File Offset: 0x00010218
		[Token(Token = "0x6003A2E")]
		public bool AddData<T>(uint varID, T initValue)
		{
			return default(bool);
		}

		// Token: 0x06003A2F RID: 14895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A2F")]
		[Address(RVA = "0x295EFE4", Offset = "0x295EFE4", VA = "0x7BBD15EFE4")]
		public void SyncReplicationData(BinaryReader reader)
		{
		}

		// Token: 0x06003A30 RID: 14896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A30")]
		public T GetData<T>(uint varID)
		{
			return null;
		}

		// Token: 0x06003A31 RID: 14897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A31")]
		public void SetData<T>(uint varID, T value)
		{
		}

		// Token: 0x06003A32 RID: 14898 RVA: 0x00012030 File Offset: 0x00010230
		[Token(Token = "0x6003A32")]
		private bool CheckType<T>(T initValue, out EReplicationInfoGroup groupID)
		{
			return default(bool);
		}

		// Token: 0x04004BCA RID: 19402
		[Token(Token = "0x4004BCA")]
		[FieldOffset(Offset = "0x10")]
		protected ReplicationData[] m_Datas;

		// Token: 0x04004BCB RID: 19403
		[Token(Token = "0x4004BCB")]
		[FieldOffset(Offset = "0x18")]
		protected int m_MaxVarCount;

		// Token: 0x04004BCC RID: 19404
		[Token(Token = "0x4004BCC")]
		[FieldOffset(Offset = "0x20")]
		protected Dictionary<uint, Delegate> m_Handlers;

		// Token: 0x02000F9D RID: 3997
		// (Invoke) Token: 0x06003A34 RID: 14900
		[Token(Token = "0x2000F9D")]
		public delegate void DataChangedHanlder<T>(T oldValue, T newValue);
	}
}
