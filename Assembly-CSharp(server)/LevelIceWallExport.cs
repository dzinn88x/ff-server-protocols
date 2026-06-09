using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000029 RID: 41
[Token(Token = "0x2000029")]
public class LevelIceWallExport : MonoBehaviour
{
	// Token: 0x06000092 RID: 146 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000092")]
	[Address(RVA = "0x2520F78", Offset = "0x2520F78", VA = "0x7BBCD20F78")]
	public LevelIceWallExport()
	{
	}

	// Token: 0x040000A3 RID: 163
	[Token(Token = "0x40000A3")]
	[FieldOffset(Offset = "0x18")]
	public Collider[] colliders;

	// Token: 0x040000A4 RID: 164
	[Token(Token = "0x40000A4")]
	[FieldOffset(Offset = "0x20")]
	public string export_name;

	// Token: 0x040000A5 RID: 165
	[Token(Token = "0x40000A5")]
	[FieldOffset(Offset = "0x28")]
	public Collider[] collisions;

	// Token: 0x040000A6 RID: 166
	[Token(Token = "0x40000A6")]
	[FieldOffset(Offset = "0x30")]
	public bool autoExportName;
}
