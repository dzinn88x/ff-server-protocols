using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010B6 RID: 4278
	[Token(Token = "0x20010B6")]
	public class BigHeadDataConfig
	{
		// Token: 0x060042B9 RID: 17081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042B9")]
		[Address(RVA = "0x14E37A8", Offset = "0x14E37A8", VA = "0x7BBBCE37A8")]
		public BigHeadDataConfig(List<BigHeadData> list)
		{
		}

		// Token: 0x060042BA RID: 17082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042BA")]
		[Address(RVA = "0x14E37D4", Offset = "0x14E37D4", VA = "0x7BBBCE37D4")]
		public BigHeadData GetData(int level)
		{
			return null;
		}

		// Token: 0x060042BB RID: 17083 RVA: 0x00014940 File Offset: 0x00012B40
		[Token(Token = "0x60042BB")]
		[Address(RVA = "0x14E3878", Offset = "0x14E3878", VA = "0x7BBBCE3878")]
		public float GetHeadShotDamageScale(int level)
		{
			return 0f;
		}

		// Token: 0x060042BC RID: 17084 RVA: 0x00014958 File Offset: 0x00012B58
		[Token(Token = "0x60042BC")]
		[Address(RVA = "0x14E389C", Offset = "0x14E389C", VA = "0x7BBBCE389C")]
		public float GetHeadScale(int level)
		{
			return 0f;
		}

		// Token: 0x040051DC RID: 20956
		[Token(Token = "0x40051DC")]
		[FieldOffset(Offset = "0x10")]
		private List<BigHeadData> m_DataList;
	}
}
