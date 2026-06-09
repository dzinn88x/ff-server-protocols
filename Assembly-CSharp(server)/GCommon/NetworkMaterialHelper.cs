using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000F38 RID: 3896
	[Token(Token = "0x2000F38")]
	public class NetworkMaterialHelper : MonoBehaviour
	{
		// Token: 0x060037D8 RID: 14296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037D8")]
		[Address(RVA = "0x24669FC", Offset = "0x24669FC", VA = "0x7BBCC669FC")]
		private void Start()
		{
		}

		// Token: 0x060037D9 RID: 14297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037D9")]
		[Address(RVA = "0x2466E5C", Offset = "0x2466E5C", VA = "0x7BBCC66E5C")]
		public NetworkMaterialHelper()
		{
		}

		// Token: 0x04004A3B RID: 19003
		[Token(Token = "0x4004A3B")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 TextureSize;

		// Token: 0x04004A3C RID: 19004
		[Token(Token = "0x4004A3C")]
		[FieldOffset(Offset = "0x20")]
		public string[] TargetMaterialNameList;

		// Token: 0x04004A3D RID: 19005
		[Token(Token = "0x4004A3D")]
		[FieldOffset(Offset = "0x28")]
		public ENetworkMaterialGroup m_NetWorkMaterialGroup;

		// Token: 0x04004A3E RID: 19006
		[Token(Token = "0x4004A3E")]
		[FieldOffset(Offset = "0x2C")]
		public bool m_IsDynamic;

		// Token: 0x04004A3F RID: 19007
		[Token(Token = "0x4004A3F")]
		private const string REGEX_MAT_END = "\\s*\\(.*\\)?$";
	}
}
