using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000211 RID: 529
[Token(Token = "0x2000211")]
public class SmallNoRender : MonoBehaviour
{
	// Token: 0x06000A64 RID: 2660 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A64")]
	[Address(RVA = "0x225FD84", Offset = "0x225FD84", VA = "0x7BBCA5FD84")]
	private void Awake()
	{
	}

	// Token: 0x06000A65 RID: 2661 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A65")]
	[Address(RVA = "0x2260018", Offset = "0x2260018", VA = "0x7BBCA60018")]
	private void Start()
	{
	}

	// Token: 0x06000A66 RID: 2662 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A66")]
	[Address(RVA = "0x22600D4", Offset = "0x22600D4", VA = "0x7BBCA600D4")]
	private void Update()
	{
	}

	// Token: 0x06000A67 RID: 2663 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A67")]
	[Address(RVA = "0x225FD88", Offset = "0x225FD88", VA = "0x7BBCA5FD88")]
	private void GetRenderers()
	{
	}

	// Token: 0x06000A68 RID: 2664 RVA: 0x00004008 File Offset: 0x00002208
	[Token(Token = "0x6000A68")]
	[Address(RVA = "0x22605BC", Offset = "0x22605BC", VA = "0x7BBCA605BC")]
	private bool ShouldRender(Renderer renderer)
	{
		return default(bool);
	}

	// Token: 0x06000A69 RID: 2665 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A69")]
	[Address(RVA = "0x22607C4", Offset = "0x22607C4", VA = "0x7BBCA607C4")]
	public SmallNoRender()
	{
	}

	// Token: 0x040009E9 RID: 2537
	[Token(Token = "0x40009E9")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<Renderer, float> mRenderAndSize;

	// Token: 0x040009EA RID: 2538
	[Token(Token = "0x40009EA")]
	[FieldOffset(Offset = "0x20")]
	private Camera mCamera;

	// Token: 0x040009EB RID: 2539
	[Token(Token = "0x40009EB")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 mCameraPosition;

	// Token: 0x040009EC RID: 2540
	[Token(Token = "0x40009EC")]
	[FieldOffset(Offset = "0x34")]
	private Vector2 mCameraPositionV2;

	// Token: 0x040009ED RID: 2541
	[Token(Token = "0x40009ED")]
	[FieldOffset(Offset = "0x3C")]
	private Vector2 mRendererPositionV2;

	// Token: 0x040009EE RID: 2542
	[Token(Token = "0x40009EE")]
	[FieldOffset(Offset = "0x48")]
	private IEnumerator<KeyValuePair<Renderer, float>> mEnumerator;

	// Token: 0x040009EF RID: 2543
	[Token(Token = "0x40009EF")]
	[FieldOffset(Offset = "0x50")]
	private Renderer mRenderer;

	// Token: 0x040009F0 RID: 2544
	[Token(Token = "0x40009F0")]
	[FieldOffset(Offset = "0x58")]
	private float mTimer;

	// Token: 0x040009F1 RID: 2545
	[Token(Token = "0x40009F1")]
	[FieldOffset(Offset = "0x5C")]
	private float mProjectSize;

	// Token: 0x040009F2 RID: 2546
	[Token(Token = "0x40009F2")]
	[FieldOffset(Offset = "0x60")]
	private int mRenderPerFrame;

	// Token: 0x040009F3 RID: 2547
	[Token(Token = "0x40009F3")]
	[FieldOffset(Offset = "0x64")]
	private bool mRefreshable;

	// Token: 0x040009F4 RID: 2548
	[Token(Token = "0x40009F4")]
	[FieldOffset(Offset = "0x0")]
	public static bool Refresh;

	// Token: 0x040009F5 RID: 2549
	[Token(Token = "0x40009F5")]
	[FieldOffset(Offset = "0x4")]
	public static float IgnoreSize;

	// Token: 0x040009F6 RID: 2550
	[Token(Token = "0x40009F6")]
	[FieldOffset(Offset = "0x8")]
	public static float SizeThreshold;

	// Token: 0x040009F7 RID: 2551
	[Token(Token = "0x40009F7")]
	[FieldOffset(Offset = "0xC")]
	public static float RefreshTime;

	// Token: 0x040009F8 RID: 2552
	[Token(Token = "0x40009F8")]
	[FieldOffset(Offset = "0x10")]
	public static int RefreshFrames;
}
