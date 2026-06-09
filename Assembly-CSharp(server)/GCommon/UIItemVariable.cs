using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x0200102B RID: 4139
	[Token(Token = "0x200102B")]
	public class UIItemVariable : MonoBehaviour
	{
		// Token: 0x06003EB7 RID: 16055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EB7")]
		[Address(RVA = "0x202E3D0", Offset = "0x202E3D0", VA = "0x7BBC82E3D0")]
		public void TryToAttachObject()
		{
		}

		// Token: 0x06003EB8 RID: 16056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EB8")]
		[Address(RVA = "0x202E2F4", Offset = "0x202E2F4", VA = "0x7BBC82E2F4")]
		public string GetExportedName()
		{
			return null;
		}

		// Token: 0x06003EB9 RID: 16057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EB9")]
		[Address(RVA = "0x202E89C", Offset = "0x202E89C", VA = "0x7BBC82E89C")]
		public string GetEUIItemExportTypeCorrespondOriginTypeName(EUIItemExportType euiItemExportType, UIItemVariable InItemVar)
		{
			return null;
		}

		// Token: 0x06003EBA RID: 16058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EBA")]
		[Address(RVA = "0x202EA90", Offset = "0x202EA90", VA = "0x7BBC82EA90")]
		public UIItemVariable()
		{
		}

		// Token: 0x04004EFE RID: 20222
		[Token(Token = "0x4004EFE")]
		[FieldOffset(Offset = "0x18")]
		public EUIItemExportType ExportType;

		// Token: 0x04004EFF RID: 20223
		[Token(Token = "0x4004EFF")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[SerializeField]
		public string CustomExportTypeName;

		// Token: 0x04004F00 RID: 20224
		[Token(Token = "0x4004F00")]
		[FieldOffset(Offset = "0x28")]
		public string ExportName;

		// Token: 0x04004F01 RID: 20225
		[Token(Token = "0x4004F01")]
		[FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public UnityEngine.Object ExportObject;
	}
}
