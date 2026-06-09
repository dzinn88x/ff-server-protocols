using System;
using AmplifyColor;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000154 RID: 340
[Token(Token = "0x2000154")]
[Attribute(Name = "AddComponentMenu", RVA = "0x10E2254", Offset = "0x10E2254")]
[ExecuteInEditMode]
public class AmplifyColorVolumeBase : MonoBehaviour
{
	// Token: 0x0600066F RID: 1647 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600066F")]
	[Address(RVA = "0x1F88C08", Offset = "0x1F88C08", VA = "0x7BBC788C08")]
	private void OnDrawGizmos()
	{
	}

	// Token: 0x06000670 RID: 1648 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000670")]
	[Address(RVA = "0x1F88E74", Offset = "0x1F88E74", VA = "0x7BBC788E74")]
	private void OnDrawGizmosSelected()
	{
	}

	// Token: 0x06000671 RID: 1649 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000671")]
	[Address(RVA = "0x1F88B88", Offset = "0x1F88B88", VA = "0x7BBC788B88")]
	public AmplifyColorVolumeBase()
	{
	}

	// Token: 0x040005B7 RID: 1463
	[Token(Token = "0x40005B7")]
	[FieldOffset(Offset = "0x18")]
	public Texture2D LutTexture;

	// Token: 0x040005B8 RID: 1464
	[Token(Token = "0x40005B8")]
	[FieldOffset(Offset = "0x20")]
	public float Exposure;

	// Token: 0x040005B9 RID: 1465
	[Token(Token = "0x40005B9")]
	[FieldOffset(Offset = "0x24")]
	public float EnterBlendTime;

	// Token: 0x040005BA RID: 1466
	[Token(Token = "0x40005BA")]
	[FieldOffset(Offset = "0x28")]
	public int Priority;

	// Token: 0x040005BB RID: 1467
	[Token(Token = "0x40005BB")]
	[FieldOffset(Offset = "0x2C")]
	public bool ShowInSceneView;

	// Token: 0x040005BC RID: 1468
	[Token(Token = "0x40005BC")]
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public VolumeEffectContainer EffectContainer;
}
