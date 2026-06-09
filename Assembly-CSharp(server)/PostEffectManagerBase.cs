using System;
using System.Collections.Generic;
using AmplifyColor;
using COW.Graphics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000156 RID: 342
[Token(Token = "0x2000156")]
[Attribute(Name = "AddComponentMenu", RVA = "0x10E22EC", Offset = "0x10E22EC")]
[ExecuteInEditMode]
public class PostEffectManagerBase : MonoBehaviour
{
	// Token: 0x17000059 RID: 89
	// (get) Token: 0x06000674 RID: 1652 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000673 RID: 1651 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000059")]
	public PostEffectProfile Profile
	{
		[Token(Token = "0x6000674")]
		[Address(RVA = "0x23C3334", Offset = "0x23C3334", VA = "0x7BBCBC3334")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000673")]
		[Address(RVA = "0x23C3190", Offset = "0x23C3190", VA = "0x7BBCBC3190")]
		set
		{
		}
	}

	// Token: 0x1700005A RID: 90
	// (get) Token: 0x06000675 RID: 1653 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700005A")]
	public Texture2D DefaultLut
	{
		[Token(Token = "0x6000675")]
		[Address(RVA = "0x23C333C", Offset = "0x23C333C", VA = "0x7BBCBC333C")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700005B RID: 91
	// (get) Token: 0x06000676 RID: 1654 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700005B")]
	public string SharedInstanceID
	{
		[Token(Token = "0x6000676")]
		[Address(RVA = "0x23C3664", Offset = "0x23C3664", VA = "0x7BBCBC3664")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700005C RID: 92
	// (get) Token: 0x06000677 RID: 1655 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700005C")]
	public Camera OwnerCamera
	{
		[Token(Token = "0x6000677")]
		[Address(RVA = "0x23C366C", Offset = "0x23C366C", VA = "0x7BBCBC366C")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000678 RID: 1656 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000678")]
	[Address(RVA = "0x23C3674", Offset = "0x23C3674", VA = "0x7BBCBC3674")]
	public void NewSharedInstanceID()
	{
	}

	// Token: 0x06000679 RID: 1657 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000679")]
	[Address(RVA = "0x23C36FC", Offset = "0x23C36FC", VA = "0x7BBCBC36FC")]
	private void ReportNotSupported()
	{
	}

	// Token: 0x0600067A RID: 1658 RVA: 0x00003288 File Offset: 0x00001488
	[Token(Token = "0x600067A")]
	[Address(RVA = "0x23C377C", Offset = "0x23C377C", VA = "0x7BBCBC377C")]
	private bool CheckSupport()
	{
		return default(bool);
	}

	// Token: 0x0600067B RID: 1659 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600067B")]
	[Address(RVA = "0x23C37B8", Offset = "0x23C37B8", VA = "0x7BBCBC37B8")]
	private void OnEnable()
	{
	}

	// Token: 0x0600067C RID: 1660 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600067C")]
	[Address(RVA = "0x23C4194", Offset = "0x23C4194", VA = "0x7BBCBC4194")]
	private void OnDisable()
	{
	}

	// Token: 0x0600067D RID: 1661 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600067D")]
	[Address(RVA = "0x23C4300", Offset = "0x23C4300", VA = "0x7BBCBC4300")]
	private void Cleanup()
	{
	}

	// Token: 0x0600067E RID: 1662 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600067E")]
	[Address(RVA = "0x23C3EB4", Offset = "0x23C3EB4", VA = "0x7BBCBC3EB4")]
	private void CheckCamera()
	{
	}

	// Token: 0x0600067F RID: 1663 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600067F")]
	[Address(RVA = "0x23C3AE8", Offset = "0x23C3AE8", VA = "0x7BBCBC3AE8")]
	private void Init()
	{
	}

	// Token: 0x06000680 RID: 1664 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000680")]
	[Address(RVA = "0x23C47F8", Offset = "0x23C47F8", VA = "0x7BBCBC47F8")]
	private void Start()
	{
	}

	// Token: 0x06000681 RID: 1665 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000681")]
	[Address(RVA = "0x23C4918", Offset = "0x23C4918", VA = "0x7BBCBC4918")]
	private void Update()
	{
	}

	// Token: 0x06000682 RID: 1666 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000682")]
	[Address(RVA = "0x23C4C4C", Offset = "0x23C4C4C", VA = "0x7BBCBC4C4C")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000683 RID: 1667 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000683")]
	[Address(RVA = "0x23C44FC", Offset = "0x23C44FC", VA = "0x7BBCBC44FC")]
	private void UpdateEnableState()
	{
	}

	// Token: 0x06000684 RID: 1668 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000684")]
	[Address(RVA = "0x23C33C8", Offset = "0x23C33C8", VA = "0x7BBCBC33C8")]
	private Texture2D CreateDefaultLut()
	{
		return null;
	}

	// Token: 0x06000685 RID: 1669 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000685")]
	[Address(RVA = "0x23C50BC", Offset = "0x23C50BC", VA = "0x7BBCBC50BC")]
	private void OnPreRender()
	{
	}

	// Token: 0x06000686 RID: 1670 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000686")]
	[Address(RVA = "0x23C51AC", Offset = "0x23C51AC", VA = "0x7BBCBC51AC")]
	private void OnPostRender()
	{
	}

	// Token: 0x06000687 RID: 1671 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000687")]
	[Address(RVA = "0x23C55E0", Offset = "0x23C55E0", VA = "0x7BBCBC55E0")]
	public void SetCameraDepth(int depth)
	{
	}

	// Token: 0x06000688 RID: 1672 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000688")]
	[Address(RVA = "0x23C55EC", Offset = "0x23C55EC", VA = "0x7BBCBC55EC")]
	public void ResetCameraDepth()
	{
	}

	// Token: 0x06000689 RID: 1673 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000689")]
	[Address(RVA = "0x23C322C", Offset = "0x23C322C", VA = "0x7BBCBC322C")]
	private void RefreshData(object[] data)
	{
	}

	// Token: 0x0600068A RID: 1674 RVA: 0x000032A0 File Offset: 0x000014A0
	[Token(Token = "0x600068A")]
	[Address(RVA = "0x23C4D6C", Offset = "0x23C4D6C", VA = "0x7BBCBC4D6C")]
	private int ValidateEnable(int mask)
	{
		return 0;
	}

	// Token: 0x0600068B RID: 1675 RVA: 0x000032B8 File Offset: 0x000014B8
	[Token(Token = "0x600068B")]
	[Address(RVA = "0x23C4FDC", Offset = "0x23C4FDC", VA = "0x7BBCBC4FDC")]
	public bool IsEffectEnable(EffectType type)
	{
		return default(bool);
	}

	// Token: 0x0600068C RID: 1676 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600068C")]
	[Address(RVA = "0x23C3F5C", Offset = "0x23C3F5C", VA = "0x7BBCBC3F5C")]
	private void CheckRenderTexture()
	{
	}

	// Token: 0x0600068D RID: 1677 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600068D")]
	[Address(RVA = "0x23C569C", Offset = "0x23C569C", VA = "0x7BBCBC569C")]
	public void SetEnable(EffectType type, bool enable)
	{
	}

	// Token: 0x0600068E RID: 1678 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600068E")]
	[Address(RVA = "0x23C30C4", Offset = "0x23C30C4", VA = "0x7BBCBC30C4")]
	public PostEffectManagerBase()
	{
	}

	// Token: 0x040005BD RID: 1469
	[Token(Token = "0x40005BD")]
	public const int LutSize = 32;

	// Token: 0x040005BE RID: 1470
	[Token(Token = "0x40005BE")]
	public const int LutWidth = 1024;

	// Token: 0x040005BF RID: 1471
	[Token(Token = "0x40005BF")]
	public const int LutHeight = 32;

	// Token: 0x040005C0 RID: 1472
	[Token(Token = "0x40005C0")]
	private const int DepthCurveLutRange = 1024;

	// Token: 0x040005C1 RID: 1473
	[Token(Token = "0x40005C1")]
	[FieldOffset(Offset = "0x18")]
	public List<Camera> extraCameras;

	// Token: 0x040005C2 RID: 1474
	[Token(Token = "0x40005C2")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private PostEffectProfile m_profile;

	// Token: 0x040005C3 RID: 1475
	[Token(Token = "0x40005C3")]
	[FieldOffset(Offset = "0x28")]
	private Camera ownerCamera;

	// Token: 0x040005C4 RID: 1476
	[Token(Token = "0x40005C4")]
	[FieldOffset(Offset = "0x30")]
	private Texture2D defaultLut;

	// Token: 0x040005C5 RID: 1477
	[Token(Token = "0x40005C5")]
	[FieldOffset(Offset = "0x38")]
	public V\u0082]ugmh[] customEffect;

	// Token: 0x040005C6 RID: 1478
	[Token(Token = "0x40005C6")]
	[FieldOffset(Offset = "0x40")]
	private int enableEffectCount;

	// Token: 0x040005C7 RID: 1479
	[Token(Token = "0x40005C7")]
	[FieldOffset(Offset = "0x44")]
	private float m_cameraDepth;

	// Token: 0x040005C8 RID: 1480
	[Token(Token = "0x40005C8")]
	[FieldOffset(Offset = "0x48")]
	[NonSerialized]
	public float blendAmount;

	// Token: 0x040005C9 RID: 1481
	[Token(Token = "0x40005C9")]
	[FieldOffset(Offset = "0x50")]
	private RenderTexture m_activeRT;

	// Token: 0x040005CA RID: 1482
	[Token(Token = "0x40005CA")]
	[FieldOffset(Offset = "0x58")]
	private AmplifyColorTriggerProxyBase actualTriggerProxy;

	// Token: 0x040005CB RID: 1483
	[Token(Token = "0x40005CB")]
	[FieldOffset(Offset = "0x60")]
	[HideInInspector]
	public VolumeEffectFlags EffectFlags;

	// Token: 0x040005CC RID: 1484
	[Token(Token = "0x40005CC")]
	[FieldOffset(Offset = "0x68")]
	[HideInInspector]
	[SerializeField]
	private string sharedInstanceID;

	// Token: 0x040005CD RID: 1485
	[Token(Token = "0x40005CD")]
	[FieldOffset(Offset = "0x70")]
	private bool silentError;

	// Token: 0x040005CE RID: 1486
	[Token(Token = "0x40005CE")]
	[FieldOffset(Offset = "0x71")]
	private bool isInit;

	// Token: 0x040005CF RID: 1487
	[Token(Token = "0x40005CF")]
	[FieldOffset(Offset = "0x74")]
	private int m_RTWidth;

	// Token: 0x040005D0 RID: 1488
	[Token(Token = "0x40005D0")]
	[FieldOffset(Offset = "0x78")]
	private int m_RTHeight;

	// Token: 0x040005D1 RID: 1489
	[Token(Token = "0x40005D1")]
	[FieldOffset(Offset = "0x7C")]
	[NonSerialized]
	public int RTWidth;

	// Token: 0x040005D2 RID: 1490
	[Token(Token = "0x40005D2")]
	[FieldOffset(Offset = "0x80")]
	[NonSerialized]
	public int RTHeight;

	// Token: 0x040005D3 RID: 1491
	[Token(Token = "0x40005D3")]
	[FieldOffset(Offset = "0x84")]
	[NonSerialized]
	public bool isLinear;

	// Token: 0x040005D4 RID: 1492
	[Token(Token = "0x40005D4")]
	[FieldOffset(Offset = "0x88")]
	private int m_enableMask;
}
